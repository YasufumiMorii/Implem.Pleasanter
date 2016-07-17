﻿using Implem.DefinitionAccessor;
using Implem.Libraries.Classes;
using Implem.Libraries.DataSources.SqlServer;
using Implem.Libraries.Utilities;
using Implem.Pleasanter.Libraries.Converts;
using Implem.Pleasanter.Libraries.DataSources;
using Implem.Pleasanter.Libraries.DataTypes;
using Implem.Pleasanter.Libraries.Html;
using Implem.Pleasanter.Libraries.HtmlParts;
using Implem.Pleasanter.Libraries.Models;
using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Responses;
using Implem.Pleasanter.Libraries.Security;
using Implem.Pleasanter.Libraries.Server;
using Implem.Pleasanter.Libraries.Settings;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace Implem.Pleasanter.Models
{
    public static class PermissionUtilities
    {
        public static HtmlBuilder TdValue(
            this HtmlBuilder hb, Column column, PermissionModel permissionModel)
        {
            switch (column.ColumnName)
            {
                case "Ver": return hb.Td(column: column, value: permissionModel.Ver);
                case "Comments": return hb.Td(column: column, value: permissionModel.Comments);
                case "Creator": return hb.Td(column: column, value: permissionModel.Creator);
                case "Updator": return hb.Td(column: column, value: permissionModel.Updator);
                case "CreatedTime": return hb.Td(column: column, value: permissionModel.CreatedTime);
                case "UpdatedTime": return hb.Td(column: column, value: permissionModel.UpdatedTime);
                default: return hb;
            }
        }

        public static ResponseCollection FormResponse(
            this ResponseCollection responseCollection, PermissionModel permissionModel)
        {
            Forms.All().Keys.ForEach(key =>
            {
                switch (key)
                {
                    default: break;
                }
            });
            return responseCollection;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public enum Types
        {
            Destination,
            Source
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public static string Editor(long siteId)
        {
            var siteModel = new SiteModel(siteId, clearSessions: true);
            var siteSettings = siteModel.PermissionsSiteSettings();
            var hb = new HtmlBuilder();
            hb.Template(
                siteId: siteModel.SiteId,
                referenceId: "Permissions",
                title: siteModel.Title.Value + " - " + Displays.EditPermissions(),
                permissionType: siteModel.PermissionType,
                verType: Versions.VerTypes.Latest,
                methodType: BaseModel.MethodTypes.Edit,
                allowAccess: siteModel.PermissionType.CanEditPermission(),
                useNavigationButtons: false,
                action: () => hb
                    .Editor(siteModel: siteModel, siteSettings: siteSettings));
            return hb.ToString();
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        private static HtmlBuilder Editor(
            this HtmlBuilder hb, SiteModel siteModel, SiteSettings siteSettings)
        {
            return hb.Form(
                attributes: new HtmlAttributes()
                    .Id_Css("PermissionForm", "edit-form")
                    .Action(Navigations.ItemAction(siteModel.SiteId, "Permissions")),
                action: () => hb
                    .Div(
                        css: "edit-form-tabs-max",
                        action: () => hb
                            .FieldTabs()
                            .Fields(siteModel: siteModel, siteSettings: siteSettings)));
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        private static HtmlBuilder FieldTabs(this HtmlBuilder hb)
        {
            return hb.Ul(css: "field-tab", action: () => hb
                .Li(action: () => hb
                    .A(
                        href: "#FieldSetPermissionEditor",
                        text: Displays.PermissionSetting())));
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        private static HtmlBuilder Fields(
            this HtmlBuilder hb, SiteModel siteModel, SiteSettings siteSettings)
        {
            SetPermissionCollectionSession(siteModel);
            return hb.FieldSet(
                id: "FieldSetPermissionEditor",
                action: () => hb
                    .Inherit(siteModel: siteModel)
                    .Div(id: "Selectables", action: () => hb
                        .Selectables(siteModel: siteModel))
                    .MainCommands(
                        siteId: siteModel.SiteId,
                        permissionType: siteModel.PermissionType,
                        verType: Versions.VerTypes.Latest,
                        backUrl: Navigations.ItemEdit(siteModel.SiteId),
                        updateButton: true));
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public static HtmlBuilder Inherit(this HtmlBuilder hb, SiteModel siteModel)
        {
            return siteModel.SiteId != 0
                ? hb.FieldDropDown(
                    controlId: "Sites_InheritPermission",
                    fieldCss: "field-auto-thin",
                    controlCss: " auto-postback",
                    labelText: Displays.Sites_InheritPermission(),
                    optionCollection: InheritTargets(siteModel.SiteId),
                    selectedValue: siteModel.InheritPermission.ToString(),
                    action: "ChangeInherit",
                    method: "put")
                : hb;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        private static Dictionary<string, ControlData> InheritTargets(long siteId)
        {
            return new Dictionary<string, ControlData>
            {
                { siteId.ToString(), new ControlData(Displays.NotInheritPermission()) },
            }.AddRange(Rds.ExecuteTable(statements:
                Rds.SelectSites(
                    column: Rds.SitesColumn()
                        .SiteId()
                        .Title(),
                    join: Rds.SitesJoinDefault(),
                    where: Rds.SitesWhere()
                        .TenantId(Sessions.TenantId())
                        .SiteId(siteId, _operator: "<>")
                        .InheritPermission(raw: "[t0].[SiteId]")
                        .PermissionType(_operator: " is not null "),
                    orderBy: Rds.SitesOrderBy().Title()))
                        .AsEnumerable()
                        .ToDictionary(
                            o => o["SiteId"].ToString(),
                            o => new ControlData(o["Title"].ToString())));
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        private static HtmlBuilder Selectables(this HtmlBuilder hb, SiteModel siteModel)
        {
            return siteModel.SiteId == siteModel.InheritPermission
                ? hb
                    .Destinations(
                        permissionCollection: siteModel.Session_PermissionDestinationCollection())
                    .Sources(
                        permissionCollection: siteModel.Session_PermissionSourceCollection())
                : hb;
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        private static void SetPermissionCollectionSession(SiteModel siteModel)
        {
            siteModel.Session_PermissionDestinationCollection(
                PermissionUtilities.DestinationCollection(
                    "Sites", siteModel.SiteId));
            siteModel.Session_PermissionSourceCollection(
                PermissionUtilities.SourceCollection(
                    "Sites",
                    siteModel.SiteId,
                    Forms.Data("SearchText")));
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        private static HtmlBuilder Destinations(
            this HtmlBuilder hb, PermissionCollection permissionCollection)
        {
            return hb.FieldSelectable(
                controlId: "PermissionDestination",
                fieldCss: "field-vertical both",
                controlContainerCss: "container-selectable",
                labelText: Displays.PermissionDestination(),
                listItemCollection: permissionCollection.OrderBy(o => o.PermissionId)
                    .ToDictionary(
                        o => o.PermissionId,
                        o => o.PermissionTitle + " - [" + o.PermissionTypeName + "]"),
                selectedValueCollection: new List<string>(),
                commandOptionPositionIsTop: true,
                commandOptionAction: () => hb
                    .Div(css: "command-left", action: () => hb
                        .Button(
                            controlId: "ReadOnly",
                            controlCss: "button-person post",
                            text: Displays.ReadOnly(),
                            onClick: Def.JavaScript.Submit,
                            action: "Set",
                            method: "put")
                        .Button(
                            controlId: "ReadWrite",
                            controlCss: "button-person post",
                            text: Displays.ReadWrite(),
                            onClick: Def.JavaScript.Submit,
                            action: "Set",
                            method: "put")
                        .Button(
                            controlId: "Leader",
                            controlCss: "button-person post",
                            text: Displays.Leader(),
                            onClick: Def.JavaScript.Submit,
                            action: "Set",
                            method: "put")
                        .Button(
                            controlId: "Manager",
                            controlCss: "button-person post",
                            text: Displays.Manager(),
                            onClick: Def.JavaScript.Submit,
                            action: "Set",
                            method: "put")
                        .Button(
                            controlId: "Delete",
                            controlCss: "button-to-right post",
                            text: Displays.DeletePermission(),
                            onClick: Def.JavaScript.Submit,
                            action: "Set",
                            method: "delete")));
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        private static HtmlBuilder Sources(
            this HtmlBuilder hb, PermissionCollection permissionCollection)
        {
            return hb.FieldSelectable(
                controlId: "PermissionSource",
                fieldCss: "field-vertical",
                controlContainerCss: "container-selectable",
                controlCss: " h550",
                labelText: Displays.PermissionSource(),
                listItemCollection: permissionCollection
                    .OrderBy(o => o.PermissionId)
                    .ToDictionary(o => o.PermissionId, o => o.PermissionTitle),
                selectedValueCollection: new List<string>(),
                commandOptionPositionIsTop: true,
                commandOptionAction: () => hb
                    .Div(css: "command-left", action: () => hb
                        .Button(
                            controlId: "Add",
                            controlCss: "button-to-left post",
                            text: Displays.AddPermission(),
                            onClick: Def.JavaScript.Submit,
                            action: "Set",
                            method: "post")
                        .Span(css: "ui-icon ui-icon-search")
                        .TextBox(
                            controlId: "SearchText",
                            controlCss: " auto-postback w100",
                            placeholder: Displays.Search(),
                            action: "Set",
                            method: "put")));
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        private static PermissionCollection DestinationCollection(
            string referenceType, long referenceId)
        {
            return new PermissionCollection(
                where: Rds.PermissionsWhere()
                    .ReferenceType(referenceType)
                    .ReferenceId(referenceId));
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        private static PermissionCollection SourceCollection(
            string referenceType, long referenceId, string searchText)
        {
            return !searchText.IsNullOrEmpty()
                ? new PermissionCollection(Rds.ExecuteTable(
                    transactional: false,
                    statements: new SqlStatement[]
                    {
                        Rds.SelectDepts(
                            column: Rds.DeptsColumn()
                                .Add("@ReferenceId_Param1 as [ReferenceId]")
                                .Add("@ReferenceType_Param1 as [ReferenceType]")
                                .DeptId()
                                .DeptName()
                                .Add("null as [UserId]")
                                .Add("null as [FullName1]")
                                .Add("null as [FullName2]")
                                .Add("1 as [FirstAndLastNameOrder]")
                                .Add("@PermissionType_Param1 as [PermissionType]"),
                            where: Rds.DeptsWhere()
                                .TenantId(Sessions.TenantId())
                                .SqlWhereExists(Rds.SqlWhereNotExists_Permissions,
                                    "[Permissions].[ReferenceId] = @ReferenceId_Param1",
                                    "[Permissions].[ReferenceType] = @ReferenceType_Param1",
                                    "[Permissions].[DeptId] = [t0].[DeptId]")
                                .SqlWhereLike(
                                    searchText,
                                    Rds.Depts_DeptId_WhereLike(),
                                    Rds.Depts_DeptCode_WhereLike(),
                                    Rds.Depts_DeptName_WhereLike()),
                            param: Rds.PermissionsParam()
                                .ReferenceType(referenceType)
                                .ReferenceId(referenceId)
                                .PermissionType(Permissions.Types.ReadWrite),
                            unionType: Sqls.UnionTypes.Union),
                        Rds.SelectUsers(
                            column: Rds.UsersColumn()
                                .Add("@ReferenceId_Param2 as [ReferenceId]")
                                .Add("@ReferenceType_Param2 as [ReferenceType]")
                                .Add("null as [DeptId]")
                                .Add("null as [DeptName]")
                                .UserId()
                                .Add("[t0].[FirstName] + ' ' + [t0].[LastName] as [FullName1]")
                                .Add("[t0].[LastName] + ' ' + [t0].[FirstName] as [FullName2]")
                                .FirstAndLastNameOrder()
                                .Add("@PermissionType_Param2 as [PermissionType]"),
                            where: Rds.UsersWhere()
                                .TenantId(Sessions.TenantId())
                                .SqlWhereExists(Rds.SqlWhereNotExists_Permissions,
                                    "[Permissions].[ReferenceId] = @ReferenceId_Param2",
                                    "[Permissions].[ReferenceType] = @ReferenceType_Param2",
                                    "[Permissions].[UserId] = [t0].[UserId]")
                                .SqlWhereLike(
                                    searchText,
                                    Rds.Users_LoginId_WhereLike(),
                                    Rds.Users_UserId_WhereLike(),
                                    Rds.Users_FirstName_WhereLike(),
                                    Rds.Users_LastName_WhereLike()),
                            param: Rds.PermissionsParam()
                                .ReferenceType(referenceType)
                                .ReferenceId(referenceId)
                                .PermissionType(Permissions.Types.ReadWrite))
                    }))
                : new PermissionCollection(get: false);
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        private static string PermissionListItem(
            SiteModel siteModel,
            Types sourceOrDestination,
            List<string> selectedValueTextCollection = null)
        {
            switch (sourceOrDestination)
            {
                case Types.Destination:
                    return new HtmlBuilder().SelectableItems(
                        listItemCollection: siteModel.Session_PermissionDestinationCollection()
                            .OrderBy(o => o.PermissionId)
                            .ToDictionary(
                                o => o.PermissionId,
                                o => o.PermissionTitle + " - [" + o.PermissionTypeName + "]"),
                        selectedValueTextCollection:
                            selectedValueTextCollection ?? new List<string>()).ToString();
                case Types.Source:
                    return new HtmlBuilder().SelectableItems(
                        listItemCollection: siteModel.Session_PermissionSourceCollection()
                            .OrderBy(o => o.PermissionId)
                            .ToDictionary(o => o.PermissionId, o => o.PermissionTitle),
                        selectedValueTextCollection:
                            selectedValueTextCollection ?? new List<string>()).ToString();
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public static string ChangeInherit(long siteId)
        {
            var inheritPermission = Forms.Long("Sites_InheritPermission");
            var hb = new HtmlBuilder();
            if (siteId == inheritPermission)
            {
                var inheritSite = new SiteModel(siteId).InheritSite();
                SetPermissionCollectionSession(inheritSite);
                hb.Selectables(inheritSite);
            }
            return new ResponseCollection()
                .Html("#Selectables", hb)
                .SetFormData("Sites_InheritPermission", inheritPermission).ToJson();
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public static string Update(long siteId)
        {
            var siteModel = new SiteModel(siteId, setByForm: true);
            if (siteModel.PermissionType.CanEditPermission())
            {
                var statements = new List<SqlStatement>();
                statements.Add(Rds.PhysicalDeletePermissions(
                    where: Rds.PermissionsWhere().ReferenceId(siteId)));
                if (siteModel.InheritPermission == siteId)
                {
                    siteModel.Session_PermissionDestinationCollection()
                        .ForEach(permissionModel =>
                            statements.Add(Insert(permissionModel, siteId)));
                }
                statements.Add(Rds.UpdateSites(
                    verUp: false,
                    where: Rds.SitesWhere().SiteId(siteModel.SiteId),
                    param: Rds.SitesParam().InheritPermission(siteModel.InheritPermission)));
                Rds.ExecuteNonQuery(transactional: true, statements: statements.ToArray());
                SiteInfo.SetSiteUserIdCollection(siteModel.InheritPermission, reload: true);
                return Messages.ResponseUpdated("permissions").ToJson();
            }
            else
            {
                return Messages.ResponseHasNotPermission().ToJson();
            }
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        private static SqlInsert Insert(PermissionModel permissionModel, long siteId)
        {
            return Rds.InsertPermissions(param: Rds.PermissionsParam()
                .ReferenceType(raw: "'Sites'")
                .ReferenceId(raw: siteId.ToString())
                .PermissionType(raw: permissionModel.PermissionType.ToLong().ToString())
                .DeptId(
                    raw: permissionModel.DeptId.ToString(),
                    _using: permissionModel.DeptId != 0)
                .UserId(raw: "0", _using: permissionModel.DeptId != 0)
                .DeptId(raw: "0", _using: permissionModel.UserId != 0)
                .UserId(
                    raw: permissionModel.UserId.ToString(),
                    _using: permissionModel.UserId != 0));
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public static string Set(long siteId)
        {
            var siteModel = new SiteModel(siteId, setByForm: true);
            var responseCollection = new ResponseCollection();
            var selectedDestinationPermissionType_ItemIdCollection = Forms.Data("PermissionDestination")
                .SortedSet(';')
                .Where(o => o != string.Empty)
                .ToList<string>();
            var selectedSourcePermissionType_ItemIdCollection = Forms.Data("PermissionSource")
                .SortedSet(';')
                .Where(o => o != string.Empty)
                .ToList<string>();
            if (Forms.Data("command") != "AddPermission" &&
                selectedDestinationPermissionType_ItemIdCollection.Contains("User," + Sessions.UserId()))
            {
                responseCollection.Message(Messages.PermissionNotSelfChange());
            }
            else
            {
                switch (Forms.Data("ControlId"))
                {
                    case "ReadOnly":
                        responseCollection.SetPermissionType(
                            siteModel,
                            selectedDestinationPermissionType_ItemIdCollection,
                            Permissions.Types.ReadOnly);
                        break;
                    case "ReadWrite":
                        responseCollection.SetPermissionType(
                            siteModel,
                            selectedDestinationPermissionType_ItemIdCollection,
                            Permissions.Types.ReadWrite);
                        break;
                    case "Leader":
                        responseCollection.SetPermissionType(
                            siteModel,
                            selectedDestinationPermissionType_ItemIdCollection,
                            Permissions.Types.Leader);
                        break;
                    case "Manager":
                        responseCollection.SetPermissionType(
                            siteModel,
                            selectedDestinationPermissionType_ItemIdCollection,
                            Permissions.Types.Manager);
                        break;
                    case "Add":
                        siteModel.Session_PermissionDestinationCollection().AddRange(
                            siteModel.Session_PermissionSourceCollection().Where(o =>
                                selectedSourcePermissionType_ItemIdCollection
                                    .Contains(o.PermissionId)));
                        siteModel.Session_PermissionDestinationCollection().Where(o =>
                            selectedSourcePermissionType_ItemIdCollection.Contains(o.PermissionId))
                            .ForEach(o =>
                                o.PermissionType = Permissions.Types.ReadWrite);
                        siteModel.Session_PermissionSourceCollection().RemoveAll(o =>
                            selectedSourcePermissionType_ItemIdCollection
                                .Contains(o.PermissionId));
                        responseCollection
                            .Html("#PermissionDestination", PermissionListItem(
                                siteModel, Types.Destination,
                                selectedSourcePermissionType_ItemIdCollection))
                            .Html("#PermissionSource", PermissionListItem(siteModel, Types.Source))
                            .SetFormData("PermissionDestination", selectedSourcePermissionType_ItemIdCollection.Join(";"))
                            .SetFormData("PermissionSource", string.Empty);
                        break;
                    case "Delete":
                        siteModel.Session_PermissionSourceCollection().AddRange(
                            siteModel.Session_PermissionDestinationCollection().Where(o =>
                                selectedDestinationPermissionType_ItemIdCollection
                                    .Contains(o.PermissionId)));
                        siteModel.Session_PermissionDestinationCollection().RemoveAll(o =>
                            selectedDestinationPermissionType_ItemIdCollection
                                .Contains(o.PermissionId));
                        responseCollection
                            .Html("#PermissionDestination", PermissionListItem(siteModel, Types.Destination))
                            .Html("#PermissionSource", PermissionListItem(
                                siteModel, Types.Source,
                                selectedDestinationPermissionType_ItemIdCollection))
                            .SetFormData("PermissionDestination", string.Empty)
                            .SetFormData("PermissionSource", selectedDestinationPermissionType_ItemIdCollection.Join(";"));
                        break;
                    case "SearchText":
                        siteModel.Session_PermissionSourceCollection(
                            PermissionUtilities.SourceCollection(
                                "Sites",
                                siteModel.SiteId,
                                Forms.Data("SearchText")));
                        siteModel.Session_PermissionSourceCollection().RemoveAll(o =>
                            siteModel.Session_PermissionDestinationCollection()
                                .Any(p => p.PermissionId == o.PermissionId));
                        responseCollection.Html("#PermissionSource", PermissionListItem(
                            siteModel, Types.Source,
                            selectedDestinationPermissionType_ItemIdCollection));
                        break;
                }
            }
            return responseCollection.ToJson();
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public static void SetPermissionType(
            this ResponseCollection responseCollection,
            SiteModel siteModel,
            List<string> selectedPermissionType_ItemIdCollection,
            Permissions.Types permissionType)
        {
            selectedPermissionType_ItemIdCollection.ForEach(permissionType_ItemId =>
                siteModel.Session_PermissionDestinationCollection()
                    .Where(o => (o.PermissionId == permissionType_ItemId))
                    .First()
                    .PermissionType = permissionType);
            responseCollection.Html("#PermissionDestination", PermissionListItem(
                siteModel,
                Types.Destination,
                selectedPermissionType_ItemIdCollection));
        }
    }
}