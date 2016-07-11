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
    public static class MailAddressesUtility
    {
        public static string Index(SiteSettings siteSettings, Permissions.Types permissionType)
        {
            var hb = new HtmlBuilder();
            var formData = DataViewFilters.SessionFormData();
            var mailAddressCollection = MailAddressCollection(siteSettings, permissionType, formData);
            var dataViewName = DataViewSelectors.Get(siteSettings.SiteId);
            return hb.Template(
                siteId: siteSettings.SiteId,
                referenceId: "MailAddresses",
                title: siteSettings.Title + " - " + Displays.List(),
                permissionType: permissionType,
                verType: Versions.VerTypes.Latest,
                methodType: BaseModel.MethodTypes.Index,
                allowAccess: permissionType.CanRead(),
                script: Libraries.Scripts.JavaScripts.DataView(
                    siteSettings: siteSettings,
                    permissionType: permissionType,
                    formData: formData,
                    dataViewName: dataViewName),
                userStyle: siteSettings.GridStyle,
                userScript: siteSettings.GridScript,
                action: () => hb
                    .Form(
                        attributes: new HtmlAttributes()
                            .Id_Css("MailAddressesForm", "main-form")
                            .Action(Navigations.ItemAction(siteSettings.SiteId)),
                        action: () => hb
                            .DataViewSelector(
                                referenceType: "MailAddresses",
                                dataViewName: dataViewName)
                            .DataViewFilters(
                                siteSettings: siteSettings,
                                siteId: siteSettings.SiteId)
                            .Aggregations(
                                siteSettings: siteSettings,
                                aggregations: mailAddressCollection.Aggregations)
                            .Div(id: "DataViewContainer", action: () => hb
                                .DataView(
                                    mailAddressCollection: mailAddressCollection,
                                    siteSettings: siteSettings,
                                    permissionType: permissionType,
                                    formData: formData,
                                    dataViewName: dataViewName))
                            .MainCommands(
                                siteId: siteSettings.SiteId,
                                permissionType: permissionType,
                                verType: Versions.VerTypes.Latest,
                                backUrl: Navigations.Index("Admins"),
                                bulkMoveButton: true,
                                bulkDeleteButton: true,
                                importButton: true,
                                exportButton: true)
                            .Div(css: "margin-bottom")
                            .Hidden(controlId: "TableName", value: "MailAddresses")
                            .Hidden(controlId: "BaseUrl", value: Navigations.BaseUrl()))
                    .Dialog_Move("items", siteSettings.SiteId, bulk: true)
                    .Div(attributes: new HtmlAttributes()
                        .Id_Css("Dialog_ExportSettings", "dialog")
                        .Title(Displays.ExportSettings()))).ToString();
        }

        private static MailAddressCollection MailAddressCollection(
            SiteSettings siteSettings,
            Permissions.Types permissionType,
            FormData formData, int offset = 0)
        {
            return new MailAddressCollection(
                siteSettings: siteSettings,
                permissionType: permissionType,
                column: GridSqlColumnCollection(siteSettings),
                where: DataViewFilters.Get(
                    siteSettings: siteSettings,
                    tableName: "MailAddresses",
                    formData: formData,
                    where: Rds.MailAddressesWhere()),
                orderBy: GridSorters.Get(
                    formData, Rds.MailAddressesOrderBy().UpdatedTime(SqlOrderBy.Types.desc)),
                offset: offset,
                pageSize: siteSettings.GridPageSize.ToInt(),
                countRecord: true,
                aggregationCollection: siteSettings.AggregationCollection);
        }

        public static HtmlBuilder DataView(
            this HtmlBuilder hb,
            MailAddressCollection mailAddressCollection,
            SiteSettings siteSettings,
            Permissions.Types permissionType,
            FormData formData,
            string dataViewName)
        {
            switch (dataViewName)
            {
                default: return hb.Grid(
                    mailAddressCollection: mailAddressCollection,
                    siteSettings: siteSettings,
                    permissionType: permissionType,
                    formData: formData);
            }
        }

        public static string DataView(
            SiteSettings siteSettings, Permissions.Types permissionType)
        {
            switch (DataViewSelectors.Get(siteSettings.SiteId))
            {
                default: return Grid(siteSettings: siteSettings, permissionType: permissionType);
            }
        }

        private static HtmlBuilder Grid(
            this HtmlBuilder hb,
            SiteSettings siteSettings,
            Permissions.Types permissionType,
            MailAddressCollection mailAddressCollection,
            FormData formData)
        {
            return hb
                .Table(
                    attributes: new HtmlAttributes()
                        .Id_Css("Grid", "grid")
                        .DataAction("GridRows")
                        .DataMethod("post"),
                    action: () => hb
                        .GridRows(
                            siteSettings: siteSettings,
                            mailAddressCollection: mailAddressCollection,
                            formData: formData))
                .Hidden(
                    controlId: "GridOffset",
                    value: siteSettings.GridPageSize == mailAddressCollection.Count()
                        ? siteSettings.GridPageSize.ToString()
                        : "-1");
        }

        private static string Grid(SiteSettings siteSettings, Permissions.Types permissionType)
        {
            var formData = DataViewFilters.SessionFormData();
            var mailAddressCollection = MailAddressCollection(siteSettings, permissionType, formData);
            return new ResponseCollection()
                .Html("#DataViewContainer", new HtmlBuilder().Grid(
                    siteSettings: siteSettings,
                    mailAddressCollection: mailAddressCollection,
                    permissionType: permissionType,
                    formData: formData))
                .Html("#Aggregations", new HtmlBuilder().Aggregations(
                    siteSettings: siteSettings,
                    aggregations: mailAddressCollection.Aggregations,
                    container: false))
                .WindowScrollTop().ToJson();
        }

        public static string GridRows(
            SiteSettings siteSettings,
            Permissions.Types permissionType,
            ResponseCollection responseCollection = null,
            int offset = 0,
            bool clearCheck = false,
            Message message = null)
        {
            var formData = DataViewFilters.SessionFormData();
            var mailAddressCollection = MailAddressCollection(siteSettings, permissionType, formData, offset);
            return (responseCollection ?? new ResponseCollection())
                .Remove(".grid tr", _using: offset == 0)
                .ClearFormData("GridCheckAll", _using: clearCheck)
                .ClearFormData("GridUnCheckedItems", _using: clearCheck)
                .ClearFormData("GridCheckedItems", _using: clearCheck)
                .Message(message)
                .Append("#Grid", new HtmlBuilder().GridRows(
                    siteSettings: siteSettings,
                    mailAddressCollection: mailAddressCollection,
                    formData: formData,
                    addHeader: offset == 0,
                    clearCheck: clearCheck))
                .Html("#Aggregations", new HtmlBuilder().Aggregations(
                    siteSettings: siteSettings,
                    aggregations: mailAddressCollection.Aggregations,
                    container: false))
                .Val("#GridOffset", siteSettings.NextPageOffset(offset, mailAddressCollection.Count()))
                .Markup()
                .ToJson();
        }

        private static HtmlBuilder GridRows(
            this HtmlBuilder hb,
            SiteSettings siteSettings,
            MailAddressCollection mailAddressCollection,
            FormData formData,
            bool addHeader = true,
            bool clearCheck = false)
        {
            var checkAll = clearCheck ? false : Forms.Bool("GridCheckAll");
            if (addHeader)
            {
                hb.GridHeader(
                    columnCollection: siteSettings.GridColumnCollection(), 
                    formData: formData,
                    checkAll: checkAll);
            }
            mailAddressCollection.ForEach(mailAddressModel => hb
                .Tr(
                    attributes: new HtmlAttributes()
                        .Class("grid-row")
                        .DataId(mailAddressModel.MailAddressId.ToString()),
                    action: () =>
                    {
                        hb.Td(action: () => hb
                            .CheckBox(
                                controlCss: "grid-check",
                                _checked: checkAll,
                                dataId: mailAddressModel.MailAddressId.ToString()));
                        siteSettings.GridColumnCollection()
                            .ForEach(column => hb
                                .TdValue(
                                    column: column,
                                    mailAddressModel: mailAddressModel));
                    }));
            return hb;
        }

        private static SqlColumnCollection GridSqlColumnCollection(SiteSettings siteSettings)
        {
            var select = Rds.MailAddressesColumn()
                .MailAddressId()
                .Creator()
                .Updator();
            siteSettings.GridColumnCollection(withTitle: true).ForEach(columnGrid =>
            {
                switch (columnGrid.ColumnName)
                {
                    case "OwnerId": select.OwnerId(); break;
                    case "OwnerType": select.OwnerType(); break;
                    case "MailAddressId": select.MailAddressId(); break;
                    case "Ver": select.Ver(); break;
                    case "MailAddress": select.MailAddress(); break;
                    case "Comments": select.Comments(); break;
                    case "Creator": select.Creator(); break;
                    case "Updator": select.Updator(); break;
                    case "CreatedTime": select.CreatedTime(); break;
                    case "UpdatedTime": select.UpdatedTime(); break;
                }
            });
            return select;
        }

        public static HtmlBuilder TdValue(
            this HtmlBuilder hb, Column column, MailAddressModel mailAddressModel)
        {
            switch (column.ColumnName)
            {
                case "Ver": return hb.Td(column: column, value: mailAddressModel.Ver);
                case "Comments": return hb.Td(column: column, value: mailAddressModel.Comments);
                case "Creator": return hb.Td(column: column, value: mailAddressModel.Creator);
                case "Updator": return hb.Td(column: column, value: mailAddressModel.Updator);
                case "CreatedTime": return hb.Td(column: column, value: mailAddressModel.CreatedTime);
                case "UpdatedTime": return hb.Td(column: column, value: mailAddressModel.UpdatedTime);
                default: return hb;
            }
        }

        public static string EditorNew()
        {
            return Editor(new MailAddressModel(
                SiteSettingsUtility.MailAddressesSiteSettings(),
                Permissions.Admins(),
                methodType: BaseModel.MethodTypes.New));
        }

        public static string Editor(long mailAddressId, bool clearSessions)
        {
            var mailAddressModel = new MailAddressModel(
                SiteSettingsUtility.MailAddressesSiteSettings(),
                Permissions.Admins(),
                mailAddressId: mailAddressId,
                clearSessions: clearSessions,
                methodType: BaseModel.MethodTypes.Edit);
            mailAddressModel.SwitchTargets = MailAddressesUtility.GetSwitchTargets(
                SiteSettingsUtility.MailAddressesSiteSettings());
            return Editor(mailAddressModel);
        }

        public static string Editor(MailAddressModel mailAddressModel)
        {
            var hb = new HtmlBuilder();
            var permissionType = Permissions.Admins();
            var siteSettings = SiteSettingsUtility.MailAddressesSiteSettings();
            return hb.Template(
                siteId: 0,
                referenceId: "MailAddresses",
                title: mailAddressModel.MethodType == BaseModel.MethodTypes.New
                    ? Displays.MailAddresses() + " - " + Displays.New()
                    : mailAddressModel.Title.Value,
                permissionType: permissionType,
                verType: mailAddressModel.VerType,
                methodType: mailAddressModel.MethodType,
                allowAccess:
                    permissionType.CanEditTenant() &&
                    mailAddressModel.AccessStatus != Databases.AccessStatuses.NotFound,
                action: () =>
                {
                    permissionType = Permissions.Types.Manager;
                    hb
                        .Editor(
                            mailAddressModel: mailAddressModel,
                            permissionType: permissionType,
                            siteSettings: siteSettings)
                        .Hidden(controlId: "TableName", value: "MailAddresses")
                        .Hidden(controlId: "Id", value: mailAddressModel.MailAddressId.ToString());
                }).ToString();
        }

        private static HtmlBuilder Editor(
            this HtmlBuilder hb,
            MailAddressModel mailAddressModel,
            Permissions.Types permissionType,
            SiteSettings siteSettings)
        {
            return hb.Div(css: "edit-form", action: () => hb
                .Form(
                    attributes: new HtmlAttributes()
                        .Id_Css("MailAddressForm", "main-form")
                        .Action(mailAddressModel.MailAddressId != 0
                            ? Navigations.Action("MailAddresses", mailAddressModel.MailAddressId)
                            : Navigations.Action("MailAddresses")),
                    action: () => hb
                        .RecordHeader(
                            id: mailAddressModel.MailAddressId,
                            baseModel: mailAddressModel,
                            tableName: "MailAddresses",
                            switchTargets: mailAddressModel.SwitchTargets?
                                .Select(o => o.ToLong()).ToList())
                        .Div(css: "edit-form-comments", action: () => hb
                            .Comments(
                                comments: mailAddressModel.Comments,
                                verType: mailAddressModel.VerType))
                        .Div(css: "edit-form-tabs", action: () => hb
                            .FieldTabs(mailAddressModel: mailAddressModel)
                            .FieldSetGeneral(
                                siteSettings: siteSettings,
                                permissionType: permissionType,
                                mailAddressModel: mailAddressModel)
                            .FieldSet(
                                attributes: new HtmlAttributes()
                                    .Id("FieldSetHistories")
                                    .DataAction("Histories")
                                    .DataMethod("get"),
                                _using: mailAddressModel.MethodType != BaseModel.MethodTypes.New)
                            .MainCommands(
                                siteId: 0,
                                permissionType: permissionType,
                                verType: mailAddressModel.VerType,
                                backUrl: Navigations.Index("MailAddresses"),
                                referenceType: "MailAddresses",
                                referenceId: mailAddressModel.MailAddressId,
                                updateButton: true,
                                mailButton: true,
                                deleteButton: true,
                                extensions: () => hb
                                    .MainCommandExtensions(
                                        mailAddressModel: mailAddressModel,
                                        siteSettings: siteSettings)))
                        .Hidden(
                            controlId: "MethodType",
                            value: mailAddressModel.MethodType.ToString().ToLower())
                        .Hidden(
                            controlId: "MailAddresses_Timestamp",
                            css: "must-transport",
                            value: mailAddressModel.Timestamp)
                        .Hidden(
                            controlId: "SwitchTargets",
                            css: "must-transport",
                            value: mailAddressModel.SwitchTargets?.Join()))
                .OutgoingMailsForm("MailAddresses", mailAddressModel.MailAddressId, mailAddressModel.Ver)
                .Dialog_Copy("MailAddresses", mailAddressModel.MailAddressId)
                .Dialog_OutgoingMail()
                .EditorExtensions(mailAddressModel: mailAddressModel, siteSettings: siteSettings));
        }

        private static HtmlBuilder FieldTabs(this HtmlBuilder hb, MailAddressModel mailAddressModel)
        {
            return hb.Ul(css: "field-tab", action: () => hb
                .Li(action: () => hb
                    .A(
                        href: "#FieldSetGeneral", 
                        text: Displays.Basic()))
                .Li(
                    _using: mailAddressModel.MethodType != BaseModel.MethodTypes.New,
                    action: () => hb
                        .A(
                            href: "#FieldSetHistories",
                            text: Displays.Histories())));
        }

        private static HtmlBuilder FieldSetGeneral(
            this HtmlBuilder hb,
            SiteSettings siteSettings,
            Permissions.Types permissionType,
            MailAddressModel mailAddressModel)
        {
            return hb.FieldSet(id: "FieldSetGeneral", action: () =>
            {
                siteSettings.ColumnCollection
                    .Where(o => o.EditorVisible.ToBool())
                    .OrderBy(o => siteSettings.EditorColumnsOrder.IndexOf(o.ColumnName))
                    .ForEach(column =>
                    {
                        switch (column.ColumnName)
                        {
                            case "OwnerId": hb.Field(siteSettings, column, mailAddressModel.MethodType, mailAddressModel.OwnerId.ToControl(column, permissionType), column.ColumnPermissionType(permissionType)); break;
                            case "OwnerType": hb.Field(siteSettings, column, mailAddressModel.MethodType, mailAddressModel.OwnerType.ToControl(column, permissionType), column.ColumnPermissionType(permissionType)); break;
                            case "MailAddressId": hb.Field(siteSettings, column, mailAddressModel.MethodType, mailAddressModel.MailAddressId.ToControl(column, permissionType), column.ColumnPermissionType(permissionType)); break;
                            case "Ver": hb.Field(siteSettings, column, mailAddressModel.MethodType, mailAddressModel.Ver.ToControl(column, permissionType), column.ColumnPermissionType(permissionType)); break;
                            case "MailAddress": hb.Field(siteSettings, column, mailAddressModel.MethodType, mailAddressModel.MailAddress.ToControl(column, permissionType), column.ColumnPermissionType(permissionType)); break;
                            case "Title": hb.Field(siteSettings, column, mailAddressModel.MethodType, mailAddressModel.Title.ToControl(column, permissionType), column.ColumnPermissionType(permissionType)); break;
                        }
                    });
                hb.VerUpCheckBox(mailAddressModel);
            });
        }

        private static HtmlBuilder MainCommandExtensions(
            this HtmlBuilder hb,
            MailAddressModel mailAddressModel,
            SiteSettings siteSettings)
        {
            return hb;
        }

        private static HtmlBuilder EditorExtensions(
            this HtmlBuilder hb,
            MailAddressModel mailAddressModel,
            SiteSettings siteSettings)
        {
            return hb;
        }

        public static List<long> GetSwitchTargets(SiteSettings siteSettings)
        {
            var switchTargets = Forms.Data("SwitchTargets").Split(',')
                .Select(o => o.ToLong())
                .Where(o => o != 0)
                .ToList();
            if (switchTargets.Count() == 0)
            {
                var formData = DataViewFilters.SessionFormData();
                switchTargets = Rds.ExecuteTable(
                    transactional: false,
                    statements: Rds.SelectMailAddresses(
                        column: Rds.MailAddressesColumn().MailAddressId(),
                        where: DataViewFilters.Get(
                            siteSettings: siteSettings,
                            tableName: "MailAddresses",
                            formData: formData,
                            where: Rds.MailAddressesWhere()),
                        orderBy: GridSorters.Get(
                            formData, Rds.MailAddressesOrderBy().UpdatedTime(SqlOrderBy.Types.desc))))
                                .AsEnumerable()
                                .Select(o => o["MailAddressId"].ToLong())
                                .ToList();    
            }
            return switchTargets;
        }

        public static ResponseCollection FormResponse(
            this ResponseCollection responseCollection, MailAddressModel mailAddressModel)
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
    }
}