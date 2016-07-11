﻿using Implem.DefinitionAccessor;
using Implem.Libraries.Classes;
using Implem.Libraries.DataSources.SqlServer;
using Implem.Libraries.Utilities;
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
    public class IssueModel : BaseItemModel
    {
        public long Id { get { return IssueId; } }
        public override long UrlId { get { return IssueId; } }
        public long IssueId = 0;
        public DateTime StartTime = 0.ToDateTime();
        public CompletionTime CompletionTime = new CompletionTime();
        public WorkValue WorkValue = new WorkValue();
        public ProgressRate ProgressRate = new ProgressRate();
        public decimal RemainingWorkValue = 0;
        public Status Status = new Status();
        public User Manager = new User();
        public User Owner = new User();
        public string ClassA = string.Empty;
        public string ClassB = string.Empty;
        public string ClassC = string.Empty;
        public string ClassD = string.Empty;
        public string ClassE = string.Empty;
        public string ClassF = string.Empty;
        public string ClassG = string.Empty;
        public string ClassH = string.Empty;
        public string ClassI = string.Empty;
        public string ClassJ = string.Empty;
        public string ClassK = string.Empty;
        public string ClassL = string.Empty;
        public string ClassM = string.Empty;
        public string ClassN = string.Empty;
        public string ClassO = string.Empty;
        public string ClassP = string.Empty;
        public string ClassQ = string.Empty;
        public string ClassR = string.Empty;
        public string ClassS = string.Empty;
        public string ClassT = string.Empty;
        public string ClassU = string.Empty;
        public string ClassV = string.Empty;
        public string ClassW = string.Empty;
        public string ClassX = string.Empty;
        public string ClassY = string.Empty;
        public string ClassZ = string.Empty;
        public decimal NumA = 0;
        public decimal NumB = 0;
        public decimal NumC = 0;
        public decimal NumD = 0;
        public decimal NumE = 0;
        public decimal NumF = 0;
        public decimal NumG = 0;
        public decimal NumH = 0;
        public decimal NumI = 0;
        public decimal NumJ = 0;
        public decimal NumK = 0;
        public decimal NumL = 0;
        public decimal NumM = 0;
        public decimal NumN = 0;
        public decimal NumO = 0;
        public decimal NumP = 0;
        public decimal NumQ = 0;
        public decimal NumR = 0;
        public decimal NumS = 0;
        public decimal NumT = 0;
        public decimal NumU = 0;
        public decimal NumV = 0;
        public decimal NumW = 0;
        public decimal NumX = 0;
        public decimal NumY = 0;
        public decimal NumZ = 0;
        public DateTime DateA = 0.ToDateTime();
        public DateTime DateB = 0.ToDateTime();
        public DateTime DateC = 0.ToDateTime();
        public DateTime DateD = 0.ToDateTime();
        public DateTime DateE = 0.ToDateTime();
        public DateTime DateF = 0.ToDateTime();
        public DateTime DateG = 0.ToDateTime();
        public DateTime DateH = 0.ToDateTime();
        public DateTime DateI = 0.ToDateTime();
        public DateTime DateJ = 0.ToDateTime();
        public DateTime DateK = 0.ToDateTime();
        public DateTime DateL = 0.ToDateTime();
        public DateTime DateM = 0.ToDateTime();
        public DateTime DateN = 0.ToDateTime();
        public DateTime DateO = 0.ToDateTime();
        public DateTime DateP = 0.ToDateTime();
        public DateTime DateQ = 0.ToDateTime();
        public DateTime DateR = 0.ToDateTime();
        public DateTime DateS = 0.ToDateTime();
        public DateTime DateT = 0.ToDateTime();
        public DateTime DateU = 0.ToDateTime();
        public DateTime DateV = 0.ToDateTime();
        public DateTime DateW = 0.ToDateTime();
        public DateTime DateX = 0.ToDateTime();
        public DateTime DateY = 0.ToDateTime();
        public DateTime DateZ = 0.ToDateTime();
        public string DescriptionA = string.Empty;
        public string DescriptionB = string.Empty;
        public string DescriptionC = string.Empty;
        public string DescriptionD = string.Empty;
        public string DescriptionE = string.Empty;
        public string DescriptionF = string.Empty;
        public string DescriptionG = string.Empty;
        public string DescriptionH = string.Empty;
        public string DescriptionI = string.Empty;
        public string DescriptionJ = string.Empty;
        public string DescriptionK = string.Empty;
        public string DescriptionL = string.Empty;
        public string DescriptionM = string.Empty;
        public string DescriptionN = string.Empty;
        public string DescriptionO = string.Empty;
        public string DescriptionP = string.Empty;
        public string DescriptionQ = string.Empty;
        public string DescriptionR = string.Empty;
        public string DescriptionS = string.Empty;
        public string DescriptionT = string.Empty;
        public string DescriptionU = string.Empty;
        public string DescriptionV = string.Empty;
        public string DescriptionW = string.Empty;
        public string DescriptionX = string.Empty;
        public string DescriptionY = string.Empty;
        public string DescriptionZ = string.Empty;
        public bool CheckA = false;
        public bool CheckB = false;
        public bool CheckC = false;
        public bool CheckD = false;
        public bool CheckE = false;
        public bool CheckF = false;
        public bool CheckG = false;
        public bool CheckH = false;
        public bool CheckI = false;
        public bool CheckJ = false;
        public bool CheckK = false;
        public bool CheckL = false;
        public bool CheckM = false;
        public bool CheckN = false;
        public bool CheckO = false;
        public bool CheckP = false;
        public bool CheckQ = false;
        public bool CheckR = false;
        public bool CheckS = false;
        public bool CheckT = false;
        public bool CheckU = false;
        public bool CheckV = false;
        public bool CheckW = false;
        public bool CheckX = false;
        public bool CheckY = false;
        public bool CheckZ = false;
        public TitleBody TitleBody { get { return new TitleBody(IssueId, Title.Value, Title.DisplayValue, Body); } }
        public long SavedIssueId = 0;
        public DateTime SavedStartTime = 0.ToDateTime();
        public DateTime SavedCompletionTime = 0.ToDateTime();
        public decimal SavedWorkValue = 0;
        public decimal SavedProgressRate = 0;
        public decimal SavedRemainingWorkValue = 0;
        public int SavedStatus = 100;
        public int SavedManager = 0;
        public int SavedOwner = 0;
        public string SavedClassA = string.Empty;
        public string SavedClassB = string.Empty;
        public string SavedClassC = string.Empty;
        public string SavedClassD = string.Empty;
        public string SavedClassE = string.Empty;
        public string SavedClassF = string.Empty;
        public string SavedClassG = string.Empty;
        public string SavedClassH = string.Empty;
        public string SavedClassI = string.Empty;
        public string SavedClassJ = string.Empty;
        public string SavedClassK = string.Empty;
        public string SavedClassL = string.Empty;
        public string SavedClassM = string.Empty;
        public string SavedClassN = string.Empty;
        public string SavedClassO = string.Empty;
        public string SavedClassP = string.Empty;
        public string SavedClassQ = string.Empty;
        public string SavedClassR = string.Empty;
        public string SavedClassS = string.Empty;
        public string SavedClassT = string.Empty;
        public string SavedClassU = string.Empty;
        public string SavedClassV = string.Empty;
        public string SavedClassW = string.Empty;
        public string SavedClassX = string.Empty;
        public string SavedClassY = string.Empty;
        public string SavedClassZ = string.Empty;
        public decimal SavedNumA = 0;
        public decimal SavedNumB = 0;
        public decimal SavedNumC = 0;
        public decimal SavedNumD = 0;
        public decimal SavedNumE = 0;
        public decimal SavedNumF = 0;
        public decimal SavedNumG = 0;
        public decimal SavedNumH = 0;
        public decimal SavedNumI = 0;
        public decimal SavedNumJ = 0;
        public decimal SavedNumK = 0;
        public decimal SavedNumL = 0;
        public decimal SavedNumM = 0;
        public decimal SavedNumN = 0;
        public decimal SavedNumO = 0;
        public decimal SavedNumP = 0;
        public decimal SavedNumQ = 0;
        public decimal SavedNumR = 0;
        public decimal SavedNumS = 0;
        public decimal SavedNumT = 0;
        public decimal SavedNumU = 0;
        public decimal SavedNumV = 0;
        public decimal SavedNumW = 0;
        public decimal SavedNumX = 0;
        public decimal SavedNumY = 0;
        public decimal SavedNumZ = 0;
        public DateTime SavedDateA = 0.ToDateTime();
        public DateTime SavedDateB = 0.ToDateTime();
        public DateTime SavedDateC = 0.ToDateTime();
        public DateTime SavedDateD = 0.ToDateTime();
        public DateTime SavedDateE = 0.ToDateTime();
        public DateTime SavedDateF = 0.ToDateTime();
        public DateTime SavedDateG = 0.ToDateTime();
        public DateTime SavedDateH = 0.ToDateTime();
        public DateTime SavedDateI = 0.ToDateTime();
        public DateTime SavedDateJ = 0.ToDateTime();
        public DateTime SavedDateK = 0.ToDateTime();
        public DateTime SavedDateL = 0.ToDateTime();
        public DateTime SavedDateM = 0.ToDateTime();
        public DateTime SavedDateN = 0.ToDateTime();
        public DateTime SavedDateO = 0.ToDateTime();
        public DateTime SavedDateP = 0.ToDateTime();
        public DateTime SavedDateQ = 0.ToDateTime();
        public DateTime SavedDateR = 0.ToDateTime();
        public DateTime SavedDateS = 0.ToDateTime();
        public DateTime SavedDateT = 0.ToDateTime();
        public DateTime SavedDateU = 0.ToDateTime();
        public DateTime SavedDateV = 0.ToDateTime();
        public DateTime SavedDateW = 0.ToDateTime();
        public DateTime SavedDateX = 0.ToDateTime();
        public DateTime SavedDateY = 0.ToDateTime();
        public DateTime SavedDateZ = 0.ToDateTime();
        public string SavedDescriptionA = string.Empty;
        public string SavedDescriptionB = string.Empty;
        public string SavedDescriptionC = string.Empty;
        public string SavedDescriptionD = string.Empty;
        public string SavedDescriptionE = string.Empty;
        public string SavedDescriptionF = string.Empty;
        public string SavedDescriptionG = string.Empty;
        public string SavedDescriptionH = string.Empty;
        public string SavedDescriptionI = string.Empty;
        public string SavedDescriptionJ = string.Empty;
        public string SavedDescriptionK = string.Empty;
        public string SavedDescriptionL = string.Empty;
        public string SavedDescriptionM = string.Empty;
        public string SavedDescriptionN = string.Empty;
        public string SavedDescriptionO = string.Empty;
        public string SavedDescriptionP = string.Empty;
        public string SavedDescriptionQ = string.Empty;
        public string SavedDescriptionR = string.Empty;
        public string SavedDescriptionS = string.Empty;
        public string SavedDescriptionT = string.Empty;
        public string SavedDescriptionU = string.Empty;
        public string SavedDescriptionV = string.Empty;
        public string SavedDescriptionW = string.Empty;
        public string SavedDescriptionX = string.Empty;
        public string SavedDescriptionY = string.Empty;
        public string SavedDescriptionZ = string.Empty;
        public bool SavedCheckA = false;
        public bool SavedCheckB = false;
        public bool SavedCheckC = false;
        public bool SavedCheckD = false;
        public bool SavedCheckE = false;
        public bool SavedCheckF = false;
        public bool SavedCheckG = false;
        public bool SavedCheckH = false;
        public bool SavedCheckI = false;
        public bool SavedCheckJ = false;
        public bool SavedCheckK = false;
        public bool SavedCheckL = false;
        public bool SavedCheckM = false;
        public bool SavedCheckN = false;
        public bool SavedCheckO = false;
        public bool SavedCheckP = false;
        public bool SavedCheckQ = false;
        public bool SavedCheckR = false;
        public bool SavedCheckS = false;
        public bool SavedCheckT = false;
        public bool SavedCheckU = false;
        public bool SavedCheckV = false;
        public bool SavedCheckW = false;
        public bool SavedCheckX = false;
        public bool SavedCheckY = false;
        public bool SavedCheckZ = false;
        public bool StartTime_Updated { get { return StartTime != SavedStartTime && StartTime != null; } }
        public bool CompletionTime_Updated { get { return CompletionTime.Value != SavedCompletionTime && CompletionTime.Value != null; } }
        public bool WorkValue_Updated { get { return WorkValue.Value != SavedWorkValue; } }
        public bool ProgressRate_Updated { get { return ProgressRate.Value != SavedProgressRate; } }
        public bool Status_Updated { get { return Status.Value != SavedStatus; } }
        public bool Manager_Updated { get { return Manager.Id != SavedManager; } }
        public bool Owner_Updated { get { return Owner.Id != SavedOwner; } }
        public bool ClassA_Updated { get { return ClassA != SavedClassA && ClassA != null; } }
        public bool ClassB_Updated { get { return ClassB != SavedClassB && ClassB != null; } }
        public bool ClassC_Updated { get { return ClassC != SavedClassC && ClassC != null; } }
        public bool ClassD_Updated { get { return ClassD != SavedClassD && ClassD != null; } }
        public bool ClassE_Updated { get { return ClassE != SavedClassE && ClassE != null; } }
        public bool ClassF_Updated { get { return ClassF != SavedClassF && ClassF != null; } }
        public bool ClassG_Updated { get { return ClassG != SavedClassG && ClassG != null; } }
        public bool ClassH_Updated { get { return ClassH != SavedClassH && ClassH != null; } }
        public bool ClassI_Updated { get { return ClassI != SavedClassI && ClassI != null; } }
        public bool ClassJ_Updated { get { return ClassJ != SavedClassJ && ClassJ != null; } }
        public bool ClassK_Updated { get { return ClassK != SavedClassK && ClassK != null; } }
        public bool ClassL_Updated { get { return ClassL != SavedClassL && ClassL != null; } }
        public bool ClassM_Updated { get { return ClassM != SavedClassM && ClassM != null; } }
        public bool ClassN_Updated { get { return ClassN != SavedClassN && ClassN != null; } }
        public bool ClassO_Updated { get { return ClassO != SavedClassO && ClassO != null; } }
        public bool ClassP_Updated { get { return ClassP != SavedClassP && ClassP != null; } }
        public bool ClassQ_Updated { get { return ClassQ != SavedClassQ && ClassQ != null; } }
        public bool ClassR_Updated { get { return ClassR != SavedClassR && ClassR != null; } }
        public bool ClassS_Updated { get { return ClassS != SavedClassS && ClassS != null; } }
        public bool ClassT_Updated { get { return ClassT != SavedClassT && ClassT != null; } }
        public bool ClassU_Updated { get { return ClassU != SavedClassU && ClassU != null; } }
        public bool ClassV_Updated { get { return ClassV != SavedClassV && ClassV != null; } }
        public bool ClassW_Updated { get { return ClassW != SavedClassW && ClassW != null; } }
        public bool ClassX_Updated { get { return ClassX != SavedClassX && ClassX != null; } }
        public bool ClassY_Updated { get { return ClassY != SavedClassY && ClassY != null; } }
        public bool ClassZ_Updated { get { return ClassZ != SavedClassZ && ClassZ != null; } }
        public bool NumA_Updated { get { return NumA != SavedNumA; } }
        public bool NumB_Updated { get { return NumB != SavedNumB; } }
        public bool NumC_Updated { get { return NumC != SavedNumC; } }
        public bool NumD_Updated { get { return NumD != SavedNumD; } }
        public bool NumE_Updated { get { return NumE != SavedNumE; } }
        public bool NumF_Updated { get { return NumF != SavedNumF; } }
        public bool NumG_Updated { get { return NumG != SavedNumG; } }
        public bool NumH_Updated { get { return NumH != SavedNumH; } }
        public bool NumI_Updated { get { return NumI != SavedNumI; } }
        public bool NumJ_Updated { get { return NumJ != SavedNumJ; } }
        public bool NumK_Updated { get { return NumK != SavedNumK; } }
        public bool NumL_Updated { get { return NumL != SavedNumL; } }
        public bool NumM_Updated { get { return NumM != SavedNumM; } }
        public bool NumN_Updated { get { return NumN != SavedNumN; } }
        public bool NumO_Updated { get { return NumO != SavedNumO; } }
        public bool NumP_Updated { get { return NumP != SavedNumP; } }
        public bool NumQ_Updated { get { return NumQ != SavedNumQ; } }
        public bool NumR_Updated { get { return NumR != SavedNumR; } }
        public bool NumS_Updated { get { return NumS != SavedNumS; } }
        public bool NumT_Updated { get { return NumT != SavedNumT; } }
        public bool NumU_Updated { get { return NumU != SavedNumU; } }
        public bool NumV_Updated { get { return NumV != SavedNumV; } }
        public bool NumW_Updated { get { return NumW != SavedNumW; } }
        public bool NumX_Updated { get { return NumX != SavedNumX; } }
        public bool NumY_Updated { get { return NumY != SavedNumY; } }
        public bool NumZ_Updated { get { return NumZ != SavedNumZ; } }
        public bool DateA_Updated { get { return DateA != SavedDateA && DateA != null; } }
        public bool DateB_Updated { get { return DateB != SavedDateB && DateB != null; } }
        public bool DateC_Updated { get { return DateC != SavedDateC && DateC != null; } }
        public bool DateD_Updated { get { return DateD != SavedDateD && DateD != null; } }
        public bool DateE_Updated { get { return DateE != SavedDateE && DateE != null; } }
        public bool DateF_Updated { get { return DateF != SavedDateF && DateF != null; } }
        public bool DateG_Updated { get { return DateG != SavedDateG && DateG != null; } }
        public bool DateH_Updated { get { return DateH != SavedDateH && DateH != null; } }
        public bool DateI_Updated { get { return DateI != SavedDateI && DateI != null; } }
        public bool DateJ_Updated { get { return DateJ != SavedDateJ && DateJ != null; } }
        public bool DateK_Updated { get { return DateK != SavedDateK && DateK != null; } }
        public bool DateL_Updated { get { return DateL != SavedDateL && DateL != null; } }
        public bool DateM_Updated { get { return DateM != SavedDateM && DateM != null; } }
        public bool DateN_Updated { get { return DateN != SavedDateN && DateN != null; } }
        public bool DateO_Updated { get { return DateO != SavedDateO && DateO != null; } }
        public bool DateP_Updated { get { return DateP != SavedDateP && DateP != null; } }
        public bool DateQ_Updated { get { return DateQ != SavedDateQ && DateQ != null; } }
        public bool DateR_Updated { get { return DateR != SavedDateR && DateR != null; } }
        public bool DateS_Updated { get { return DateS != SavedDateS && DateS != null; } }
        public bool DateT_Updated { get { return DateT != SavedDateT && DateT != null; } }
        public bool DateU_Updated { get { return DateU != SavedDateU && DateU != null; } }
        public bool DateV_Updated { get { return DateV != SavedDateV && DateV != null; } }
        public bool DateW_Updated { get { return DateW != SavedDateW && DateW != null; } }
        public bool DateX_Updated { get { return DateX != SavedDateX && DateX != null; } }
        public bool DateY_Updated { get { return DateY != SavedDateY && DateY != null; } }
        public bool DateZ_Updated { get { return DateZ != SavedDateZ && DateZ != null; } }
        public bool DescriptionA_Updated { get { return DescriptionA != SavedDescriptionA && DescriptionA != null; } }
        public bool DescriptionB_Updated { get { return DescriptionB != SavedDescriptionB && DescriptionB != null; } }
        public bool DescriptionC_Updated { get { return DescriptionC != SavedDescriptionC && DescriptionC != null; } }
        public bool DescriptionD_Updated { get { return DescriptionD != SavedDescriptionD && DescriptionD != null; } }
        public bool DescriptionE_Updated { get { return DescriptionE != SavedDescriptionE && DescriptionE != null; } }
        public bool DescriptionF_Updated { get { return DescriptionF != SavedDescriptionF && DescriptionF != null; } }
        public bool DescriptionG_Updated { get { return DescriptionG != SavedDescriptionG && DescriptionG != null; } }
        public bool DescriptionH_Updated { get { return DescriptionH != SavedDescriptionH && DescriptionH != null; } }
        public bool DescriptionI_Updated { get { return DescriptionI != SavedDescriptionI && DescriptionI != null; } }
        public bool DescriptionJ_Updated { get { return DescriptionJ != SavedDescriptionJ && DescriptionJ != null; } }
        public bool DescriptionK_Updated { get { return DescriptionK != SavedDescriptionK && DescriptionK != null; } }
        public bool DescriptionL_Updated { get { return DescriptionL != SavedDescriptionL && DescriptionL != null; } }
        public bool DescriptionM_Updated { get { return DescriptionM != SavedDescriptionM && DescriptionM != null; } }
        public bool DescriptionN_Updated { get { return DescriptionN != SavedDescriptionN && DescriptionN != null; } }
        public bool DescriptionO_Updated { get { return DescriptionO != SavedDescriptionO && DescriptionO != null; } }
        public bool DescriptionP_Updated { get { return DescriptionP != SavedDescriptionP && DescriptionP != null; } }
        public bool DescriptionQ_Updated { get { return DescriptionQ != SavedDescriptionQ && DescriptionQ != null; } }
        public bool DescriptionR_Updated { get { return DescriptionR != SavedDescriptionR && DescriptionR != null; } }
        public bool DescriptionS_Updated { get { return DescriptionS != SavedDescriptionS && DescriptionS != null; } }
        public bool DescriptionT_Updated { get { return DescriptionT != SavedDescriptionT && DescriptionT != null; } }
        public bool DescriptionU_Updated { get { return DescriptionU != SavedDescriptionU && DescriptionU != null; } }
        public bool DescriptionV_Updated { get { return DescriptionV != SavedDescriptionV && DescriptionV != null; } }
        public bool DescriptionW_Updated { get { return DescriptionW != SavedDescriptionW && DescriptionW != null; } }
        public bool DescriptionX_Updated { get { return DescriptionX != SavedDescriptionX && DescriptionX != null; } }
        public bool DescriptionY_Updated { get { return DescriptionY != SavedDescriptionY && DescriptionY != null; } }
        public bool DescriptionZ_Updated { get { return DescriptionZ != SavedDescriptionZ && DescriptionZ != null; } }
        public bool CheckA_Updated { get { return CheckA != SavedCheckA; } }
        public bool CheckB_Updated { get { return CheckB != SavedCheckB; } }
        public bool CheckC_Updated { get { return CheckC != SavedCheckC; } }
        public bool CheckD_Updated { get { return CheckD != SavedCheckD; } }
        public bool CheckE_Updated { get { return CheckE != SavedCheckE; } }
        public bool CheckF_Updated { get { return CheckF != SavedCheckF; } }
        public bool CheckG_Updated { get { return CheckG != SavedCheckG; } }
        public bool CheckH_Updated { get { return CheckH != SavedCheckH; } }
        public bool CheckI_Updated { get { return CheckI != SavedCheckI; } }
        public bool CheckJ_Updated { get { return CheckJ != SavedCheckJ; } }
        public bool CheckK_Updated { get { return CheckK != SavedCheckK; } }
        public bool CheckL_Updated { get { return CheckL != SavedCheckL; } }
        public bool CheckM_Updated { get { return CheckM != SavedCheckM; } }
        public bool CheckN_Updated { get { return CheckN != SavedCheckN; } }
        public bool CheckO_Updated { get { return CheckO != SavedCheckO; } }
        public bool CheckP_Updated { get { return CheckP != SavedCheckP; } }
        public bool CheckQ_Updated { get { return CheckQ != SavedCheckQ; } }
        public bool CheckR_Updated { get { return CheckR != SavedCheckR; } }
        public bool CheckS_Updated { get { return CheckS != SavedCheckS; } }
        public bool CheckT_Updated { get { return CheckT != SavedCheckT; } }
        public bool CheckU_Updated { get { return CheckU != SavedCheckU; } }
        public bool CheckV_Updated { get { return CheckV != SavedCheckV; } }
        public bool CheckW_Updated { get { return CheckW != SavedCheckW; } }
        public bool CheckX_Updated { get { return CheckX != SavedCheckX; } }
        public bool CheckY_Updated { get { return CheckY != SavedCheckY; } }
        public bool CheckZ_Updated { get { return CheckZ != SavedCheckZ; } }

        public string PropertyValue(string name)
        {
            switch (name)
            {
                case "SiteId": return SiteId.ToString();
                case "UpdatedTime": return UpdatedTime.Value.ToString();
                case "IssueId": return IssueId.ToString();
                case "Ver": return Ver.ToString();
                case "Title": return Title.Value;
                case "Body": return Body;
                case "TitleBody": return TitleBody.ToString();
                case "StartTime": return StartTime.ToString();
                case "CompletionTime": return CompletionTime.Value.ToString();
                case "WorkValue": return WorkValue.Value.ToString();
                case "ProgressRate": return ProgressRate.Value.ToString();
                case "RemainingWorkValue": return RemainingWorkValue.ToString();
                case "Status": return Status.Value.ToString();
                case "Manager": return Manager.Id.ToString();
                case "Owner": return Owner.Id.ToString();
                case "ClassA": return ClassA;
                case "ClassB": return ClassB;
                case "ClassC": return ClassC;
                case "ClassD": return ClassD;
                case "ClassE": return ClassE;
                case "ClassF": return ClassF;
                case "ClassG": return ClassG;
                case "ClassH": return ClassH;
                case "ClassI": return ClassI;
                case "ClassJ": return ClassJ;
                case "ClassK": return ClassK;
                case "ClassL": return ClassL;
                case "ClassM": return ClassM;
                case "ClassN": return ClassN;
                case "ClassO": return ClassO;
                case "ClassP": return ClassP;
                case "ClassQ": return ClassQ;
                case "ClassR": return ClassR;
                case "ClassS": return ClassS;
                case "ClassT": return ClassT;
                case "ClassU": return ClassU;
                case "ClassV": return ClassV;
                case "ClassW": return ClassW;
                case "ClassX": return ClassX;
                case "ClassY": return ClassY;
                case "ClassZ": return ClassZ;
                case "NumA": return NumA.ToString();
                case "NumB": return NumB.ToString();
                case "NumC": return NumC.ToString();
                case "NumD": return NumD.ToString();
                case "NumE": return NumE.ToString();
                case "NumF": return NumF.ToString();
                case "NumG": return NumG.ToString();
                case "NumH": return NumH.ToString();
                case "NumI": return NumI.ToString();
                case "NumJ": return NumJ.ToString();
                case "NumK": return NumK.ToString();
                case "NumL": return NumL.ToString();
                case "NumM": return NumM.ToString();
                case "NumN": return NumN.ToString();
                case "NumO": return NumO.ToString();
                case "NumP": return NumP.ToString();
                case "NumQ": return NumQ.ToString();
                case "NumR": return NumR.ToString();
                case "NumS": return NumS.ToString();
                case "NumT": return NumT.ToString();
                case "NumU": return NumU.ToString();
                case "NumV": return NumV.ToString();
                case "NumW": return NumW.ToString();
                case "NumX": return NumX.ToString();
                case "NumY": return NumY.ToString();
                case "NumZ": return NumZ.ToString();
                case "DateA": return DateA.ToString();
                case "DateB": return DateB.ToString();
                case "DateC": return DateC.ToString();
                case "DateD": return DateD.ToString();
                case "DateE": return DateE.ToString();
                case "DateF": return DateF.ToString();
                case "DateG": return DateG.ToString();
                case "DateH": return DateH.ToString();
                case "DateI": return DateI.ToString();
                case "DateJ": return DateJ.ToString();
                case "DateK": return DateK.ToString();
                case "DateL": return DateL.ToString();
                case "DateM": return DateM.ToString();
                case "DateN": return DateN.ToString();
                case "DateO": return DateO.ToString();
                case "DateP": return DateP.ToString();
                case "DateQ": return DateQ.ToString();
                case "DateR": return DateR.ToString();
                case "DateS": return DateS.ToString();
                case "DateT": return DateT.ToString();
                case "DateU": return DateU.ToString();
                case "DateV": return DateV.ToString();
                case "DateW": return DateW.ToString();
                case "DateX": return DateX.ToString();
                case "DateY": return DateY.ToString();
                case "DateZ": return DateZ.ToString();
                case "DescriptionA": return DescriptionA;
                case "DescriptionB": return DescriptionB;
                case "DescriptionC": return DescriptionC;
                case "DescriptionD": return DescriptionD;
                case "DescriptionE": return DescriptionE;
                case "DescriptionF": return DescriptionF;
                case "DescriptionG": return DescriptionG;
                case "DescriptionH": return DescriptionH;
                case "DescriptionI": return DescriptionI;
                case "DescriptionJ": return DescriptionJ;
                case "DescriptionK": return DescriptionK;
                case "DescriptionL": return DescriptionL;
                case "DescriptionM": return DescriptionM;
                case "DescriptionN": return DescriptionN;
                case "DescriptionO": return DescriptionO;
                case "DescriptionP": return DescriptionP;
                case "DescriptionQ": return DescriptionQ;
                case "DescriptionR": return DescriptionR;
                case "DescriptionS": return DescriptionS;
                case "DescriptionT": return DescriptionT;
                case "DescriptionU": return DescriptionU;
                case "DescriptionV": return DescriptionV;
                case "DescriptionW": return DescriptionW;
                case "DescriptionX": return DescriptionX;
                case "DescriptionY": return DescriptionY;
                case "DescriptionZ": return DescriptionZ;
                case "CheckA": return CheckA.ToString();
                case "CheckB": return CheckB.ToString();
                case "CheckC": return CheckC.ToString();
                case "CheckD": return CheckD.ToString();
                case "CheckE": return CheckE.ToString();
                case "CheckF": return CheckF.ToString();
                case "CheckG": return CheckG.ToString();
                case "CheckH": return CheckH.ToString();
                case "CheckI": return CheckI.ToString();
                case "CheckJ": return CheckJ.ToString();
                case "CheckK": return CheckK.ToString();
                case "CheckL": return CheckL.ToString();
                case "CheckM": return CheckM.ToString();
                case "CheckN": return CheckN.ToString();
                case "CheckO": return CheckO.ToString();
                case "CheckP": return CheckP.ToString();
                case "CheckQ": return CheckQ.ToString();
                case "CheckR": return CheckR.ToString();
                case "CheckS": return CheckS.ToString();
                case "CheckT": return CheckT.ToString();
                case "CheckU": return CheckU.ToString();
                case "CheckV": return CheckV.ToString();
                case "CheckW": return CheckW.ToString();
                case "CheckX": return CheckX.ToString();
                case "CheckY": return CheckY.ToString();
                case "CheckZ": return CheckZ.ToString();
                case "Comments": return Comments.ToJson();
                case "Creator": return Creator.Id.ToString();
                case "Updator": return Updator.Id.ToString();
                case "CreatedTime": return CreatedTime.Value.ToString();
                case "VerUp": return VerUp.ToString();
                case "Timestamp": return Timestamp;
                default: return null;
            }
        }

        public List<long> SwitchTargets;

        public IssueModel(SiteSettings siteSettings)
        {
            SiteSettings = siteSettings;
        }

        public IssueModel(long issueId, long siteId, bool setByForm = false)
        {
            IssueId = issueId;
            SiteId = siteId;
            if (setByForm) SetByForm();
            Get();
        }

        public IssueModel()
        {
        }

        public IssueModel(
            SiteSettings siteSettings, 
            Permissions.Types permissionType,
            bool setByForm = false,
            MethodTypes methodType = MethodTypes.NotSet)
        {
            OnConstructing();
            Manager = SiteInfo.User(Sessions.UserId());
            Owner = SiteInfo.User(Sessions.UserId());
            SiteSettings = siteSettings;
            PermissionType = permissionType;
            if (setByForm) SetByForm();
            MethodType = methodType;
            OnConstructed();
        }

        public IssueModel(
            SiteSettings siteSettings, 
            Permissions.Types permissionType,
            long issueId,
            bool clearSessions = false,
            bool setByForm = false,
            List<long> switchTargets = null,
            MethodTypes methodType = MethodTypes.NotSet)
        {
            OnConstructing();
            SiteSettings = siteSettings;
            IssueId = issueId;
            PermissionType = permissionType;
            SiteId = SiteSettings.SiteId;
            Get();
            if (clearSessions) ClearSessions();
            if (setByForm) SetByForm();
            SwitchTargets = switchTargets;
            MethodType = methodType;
            OnConstructed();
        }

        public IssueModel(
            SiteSettings siteSettings, 
            Permissions.Types permissionType,
            DataRow dataRow)
        {
            OnConstructing();
            SiteSettings = siteSettings;
            Set(dataRow);
            OnConstructed();
        }

        private void OnConstructing()
        {
        }

        private void OnConstructed()
        {
        }

        public void ClearSessions()
        {
        }

        public IssueModel Get(
            Sqls.TableTypes tableType = Sqls.TableTypes.Normal,
            SqlColumnCollection column = null,
            SqlJoinCollection join = null,
            SqlWhereCollection where = null,
            SqlOrderByCollection orderBy = null,
            SqlParamCollection param = null,
            bool distinct = false,
            int top = 0)
        {
            Set(Rds.ExecuteTable(statements: Rds.SelectIssues(
                tableType: tableType,
                column: column ?? Rds.IssuesColumnDefault(),
                join: join ??  Rds.IssuesJoinDefault(),
                where: where ?? Rds.IssuesWhereDefault(this),
                orderBy: orderBy ?? null,
                param: param ?? null,
                distinct: distinct,
                top: top)));
            return this;
        }

        public string Create(
            Sqls.TableTypes tableType = Sqls.TableTypes.Normal,
            SqlParamCollection param = null,
            bool paramAll = false)
        {
            var error = ValidateBeforeCreate();
            if (error != null) return error;
            OnCreating();
            var newId = Rds.ExecuteScalar_long(
                transactional: true,
                statements: new SqlStatement[]
                {
                    Rds.InsertItems(
                        selectIdentity: true,
                        param: Rds.ItemsParam()
                            .ReferenceType("Issues")
                            .SiteId(SiteId)
                            .Title(Title.Value)),
                    Rds.InsertIssues(
                        tableType: tableType,
                        param: param ?? Rds.IssuesParamDefault(
                            this, setDefault: true, paramAll: paramAll)),
                    InsertLinks(SiteSettings, selectIdentity: true),
                });
            IssueId = newId != 0 ? newId : IssueId;
            SynchronizeSummary();
            Get();
            Rds.ExecuteNonQuery(statements:
                Rds.UpdateItems(
                    param: Rds.ItemsParam()
                        .Title(IssuesUtility.TitleDisplayValue(SiteSettings, this))
                        .Subset(Jsons.ToJson(new IssueSubset(this, SiteSettings))),
                    where: Rds.ItemsWhere().ReferenceId(IssueId)));
            OnCreated();
            return RecordResponse(this, Messages.Created(Title.ToString()));
        }

        private void OnCreating()
        {
        }

        private void OnCreated()
        {
        }

        private string ValidateBeforeCreate()
        {
            if (!PermissionType.CanCreate())
            {
                return Messages.ResponseHasNotPermission().ToJson();
            }
            foreach(var controlId in Forms.Keys())
            {
                switch (controlId)
                {
                    case "Issues_SiteId": if (!SiteSettings.AllColumn("SiteId").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_UpdatedTime": if (!SiteSettings.AllColumn("UpdatedTime").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_IssueId": if (!SiteSettings.AllColumn("IssueId").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_Ver": if (!SiteSettings.AllColumn("Ver").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_Title": if (!SiteSettings.AllColumn("Title").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_Body": if (!SiteSettings.AllColumn("Body").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_TitleBody": if (!SiteSettings.AllColumn("TitleBody").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_StartTime": if (!SiteSettings.AllColumn("StartTime").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CompletionTime": if (!SiteSettings.AllColumn("CompletionTime").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_WorkValue": if (!SiteSettings.AllColumn("WorkValue").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ProgressRate": if (!SiteSettings.AllColumn("ProgressRate").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_RemainingWorkValue": if (!SiteSettings.AllColumn("RemainingWorkValue").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_Status": if (!SiteSettings.AllColumn("Status").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_Manager": if (!SiteSettings.AllColumn("Manager").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_Owner": if (!SiteSettings.AllColumn("Owner").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassA": if (!SiteSettings.AllColumn("ClassA").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassB": if (!SiteSettings.AllColumn("ClassB").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassC": if (!SiteSettings.AllColumn("ClassC").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassD": if (!SiteSettings.AllColumn("ClassD").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassE": if (!SiteSettings.AllColumn("ClassE").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassF": if (!SiteSettings.AllColumn("ClassF").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassG": if (!SiteSettings.AllColumn("ClassG").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassH": if (!SiteSettings.AllColumn("ClassH").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassI": if (!SiteSettings.AllColumn("ClassI").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassJ": if (!SiteSettings.AllColumn("ClassJ").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassK": if (!SiteSettings.AllColumn("ClassK").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassL": if (!SiteSettings.AllColumn("ClassL").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassM": if (!SiteSettings.AllColumn("ClassM").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassN": if (!SiteSettings.AllColumn("ClassN").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassO": if (!SiteSettings.AllColumn("ClassO").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassP": if (!SiteSettings.AllColumn("ClassP").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassQ": if (!SiteSettings.AllColumn("ClassQ").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassR": if (!SiteSettings.AllColumn("ClassR").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassS": if (!SiteSettings.AllColumn("ClassS").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassT": if (!SiteSettings.AllColumn("ClassT").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassU": if (!SiteSettings.AllColumn("ClassU").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassV": if (!SiteSettings.AllColumn("ClassV").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassW": if (!SiteSettings.AllColumn("ClassW").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassX": if (!SiteSettings.AllColumn("ClassX").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassY": if (!SiteSettings.AllColumn("ClassY").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassZ": if (!SiteSettings.AllColumn("ClassZ").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumA": if (!SiteSettings.AllColumn("NumA").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumB": if (!SiteSettings.AllColumn("NumB").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumC": if (!SiteSettings.AllColumn("NumC").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumD": if (!SiteSettings.AllColumn("NumD").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumE": if (!SiteSettings.AllColumn("NumE").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumF": if (!SiteSettings.AllColumn("NumF").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumG": if (!SiteSettings.AllColumn("NumG").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumH": if (!SiteSettings.AllColumn("NumH").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumI": if (!SiteSettings.AllColumn("NumI").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumJ": if (!SiteSettings.AllColumn("NumJ").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumK": if (!SiteSettings.AllColumn("NumK").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumL": if (!SiteSettings.AllColumn("NumL").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumM": if (!SiteSettings.AllColumn("NumM").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumN": if (!SiteSettings.AllColumn("NumN").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumO": if (!SiteSettings.AllColumn("NumO").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumP": if (!SiteSettings.AllColumn("NumP").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumQ": if (!SiteSettings.AllColumn("NumQ").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumR": if (!SiteSettings.AllColumn("NumR").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumS": if (!SiteSettings.AllColumn("NumS").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumT": if (!SiteSettings.AllColumn("NumT").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumU": if (!SiteSettings.AllColumn("NumU").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumV": if (!SiteSettings.AllColumn("NumV").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumW": if (!SiteSettings.AllColumn("NumW").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumX": if (!SiteSettings.AllColumn("NumX").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumY": if (!SiteSettings.AllColumn("NumY").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumZ": if (!SiteSettings.AllColumn("NumZ").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateA": if (!SiteSettings.AllColumn("DateA").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateB": if (!SiteSettings.AllColumn("DateB").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateC": if (!SiteSettings.AllColumn("DateC").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateD": if (!SiteSettings.AllColumn("DateD").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateE": if (!SiteSettings.AllColumn("DateE").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateF": if (!SiteSettings.AllColumn("DateF").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateG": if (!SiteSettings.AllColumn("DateG").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateH": if (!SiteSettings.AllColumn("DateH").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateI": if (!SiteSettings.AllColumn("DateI").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateJ": if (!SiteSettings.AllColumn("DateJ").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateK": if (!SiteSettings.AllColumn("DateK").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateL": if (!SiteSettings.AllColumn("DateL").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateM": if (!SiteSettings.AllColumn("DateM").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateN": if (!SiteSettings.AllColumn("DateN").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateO": if (!SiteSettings.AllColumn("DateO").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateP": if (!SiteSettings.AllColumn("DateP").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateQ": if (!SiteSettings.AllColumn("DateQ").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateR": if (!SiteSettings.AllColumn("DateR").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateS": if (!SiteSettings.AllColumn("DateS").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateT": if (!SiteSettings.AllColumn("DateT").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateU": if (!SiteSettings.AllColumn("DateU").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateV": if (!SiteSettings.AllColumn("DateV").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateW": if (!SiteSettings.AllColumn("DateW").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateX": if (!SiteSettings.AllColumn("DateX").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateY": if (!SiteSettings.AllColumn("DateY").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateZ": if (!SiteSettings.AllColumn("DateZ").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionA": if (!SiteSettings.AllColumn("DescriptionA").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionB": if (!SiteSettings.AllColumn("DescriptionB").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionC": if (!SiteSettings.AllColumn("DescriptionC").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionD": if (!SiteSettings.AllColumn("DescriptionD").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionE": if (!SiteSettings.AllColumn("DescriptionE").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionF": if (!SiteSettings.AllColumn("DescriptionF").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionG": if (!SiteSettings.AllColumn("DescriptionG").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionH": if (!SiteSettings.AllColumn("DescriptionH").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionI": if (!SiteSettings.AllColumn("DescriptionI").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionJ": if (!SiteSettings.AllColumn("DescriptionJ").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionK": if (!SiteSettings.AllColumn("DescriptionK").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionL": if (!SiteSettings.AllColumn("DescriptionL").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionM": if (!SiteSettings.AllColumn("DescriptionM").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionN": if (!SiteSettings.AllColumn("DescriptionN").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionO": if (!SiteSettings.AllColumn("DescriptionO").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionP": if (!SiteSettings.AllColumn("DescriptionP").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionQ": if (!SiteSettings.AllColumn("DescriptionQ").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionR": if (!SiteSettings.AllColumn("DescriptionR").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionS": if (!SiteSettings.AllColumn("DescriptionS").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionT": if (!SiteSettings.AllColumn("DescriptionT").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionU": if (!SiteSettings.AllColumn("DescriptionU").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionV": if (!SiteSettings.AllColumn("DescriptionV").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionW": if (!SiteSettings.AllColumn("DescriptionW").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionX": if (!SiteSettings.AllColumn("DescriptionX").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionY": if (!SiteSettings.AllColumn("DescriptionY").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionZ": if (!SiteSettings.AllColumn("DescriptionZ").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckA": if (!SiteSettings.AllColumn("CheckA").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckB": if (!SiteSettings.AllColumn("CheckB").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckC": if (!SiteSettings.AllColumn("CheckC").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckD": if (!SiteSettings.AllColumn("CheckD").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckE": if (!SiteSettings.AllColumn("CheckE").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckF": if (!SiteSettings.AllColumn("CheckF").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckG": if (!SiteSettings.AllColumn("CheckG").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckH": if (!SiteSettings.AllColumn("CheckH").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckI": if (!SiteSettings.AllColumn("CheckI").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckJ": if (!SiteSettings.AllColumn("CheckJ").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckK": if (!SiteSettings.AllColumn("CheckK").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckL": if (!SiteSettings.AllColumn("CheckL").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckM": if (!SiteSettings.AllColumn("CheckM").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckN": if (!SiteSettings.AllColumn("CheckN").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckO": if (!SiteSettings.AllColumn("CheckO").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckP": if (!SiteSettings.AllColumn("CheckP").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckQ": if (!SiteSettings.AllColumn("CheckQ").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckR": if (!SiteSettings.AllColumn("CheckR").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckS": if (!SiteSettings.AllColumn("CheckS").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckT": if (!SiteSettings.AllColumn("CheckT").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckU": if (!SiteSettings.AllColumn("CheckU").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckV": if (!SiteSettings.AllColumn("CheckV").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckW": if (!SiteSettings.AllColumn("CheckW").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckX": if (!SiteSettings.AllColumn("CheckX").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckY": if (!SiteSettings.AllColumn("CheckY").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckZ": if (!SiteSettings.AllColumn("CheckZ").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_Comments": if (!SiteSettings.AllColumn("Comments").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_Creator": if (!SiteSettings.AllColumn("Creator").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_Updator": if (!SiteSettings.AllColumn("Updator").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CreatedTime": if (!SiteSettings.AllColumn("CreatedTime").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_VerUp": if (!SiteSettings.AllColumn("VerUp").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_Timestamp": if (!SiteSettings.AllColumn("Timestamp").CanCreate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                }
            }
            return null;
        }

        public string Update(SqlParamCollection param = null, bool paramAll = false)
        {
            var error = ValidateBeforeUpdate();
            if (error != null) return error;
            SetBySession();
            OnUpdating(ref param);
            var timestamp = Timestamp.ToDateTime();
            var count = Rds.ExecuteScalar_int(
                transactional: true,
                statements: new SqlStatement[]
                {
                    Rds.UpdateIssues(
                        verUp: VerUp,
                        where: Rds.IssuesWhereDefault(this)
                            .UpdatedTime(timestamp, _using: timestamp.NotZero()),
                        param: param ?? Rds.IssuesParamDefault(this, paramAll: paramAll),
                        countRecord: true),
                    Rds.If("@@rowcount = 1"),
                    Rds.UpdateItems(
                        where: Rds.ItemsWhere().ReferenceId(IssueId),
                        param: Rds.ItemsParam()
                            .SiteId(SiteId)
                            .Title(IssuesUtility.TitleDisplayValue(SiteSettings, this))
                            .Subset(Jsons.ToJson(new IssueSubset(this, SiteSettings)))
                            .MaintenanceTarget(true)),
                    Rds.PhysicalDeleteLinks(
                        where: Rds.LinksWhere().SourceId(IssueId)),
                    InsertLinks(SiteSettings),
                    Rds.End()
                });
            if (count == 0) return ResponseConflicts();
            SynchronizeSummary();
            Get();
            var responseCollection = new IssuesResponseCollection(this);
            OnUpdated(ref responseCollection);
            return ResponseByUpdate(responseCollection)
                .PrependComment(Comments, VerType)
                .ToJson();
        }

        private SqlInsert InsertLinks(
            SiteSettings siteSettings, bool selectIdentity = false)
        {
            var link = new Dictionary<long, long>();
            siteSettings.ColumnCollection.Where(o => o.Link.ToBool()).ForEach(column =>
            {
                switch (column.ColumnName)
                {
                    case "ClassA": if (ClassA.ToLong() != 0 && !link.ContainsKey(ClassA.ToLong())) link.Add(ClassA.ToLong(), IssueId); break;
                    case "ClassB": if (ClassB.ToLong() != 0 && !link.ContainsKey(ClassB.ToLong())) link.Add(ClassB.ToLong(), IssueId); break;
                    case "ClassC": if (ClassC.ToLong() != 0 && !link.ContainsKey(ClassC.ToLong())) link.Add(ClassC.ToLong(), IssueId); break;
                    case "ClassD": if (ClassD.ToLong() != 0 && !link.ContainsKey(ClassD.ToLong())) link.Add(ClassD.ToLong(), IssueId); break;
                    case "ClassE": if (ClassE.ToLong() != 0 && !link.ContainsKey(ClassE.ToLong())) link.Add(ClassE.ToLong(), IssueId); break;
                    case "ClassF": if (ClassF.ToLong() != 0 && !link.ContainsKey(ClassF.ToLong())) link.Add(ClassF.ToLong(), IssueId); break;
                    case "ClassG": if (ClassG.ToLong() != 0 && !link.ContainsKey(ClassG.ToLong())) link.Add(ClassG.ToLong(), IssueId); break;
                    case "ClassH": if (ClassH.ToLong() != 0 && !link.ContainsKey(ClassH.ToLong())) link.Add(ClassH.ToLong(), IssueId); break;
                    case "ClassI": if (ClassI.ToLong() != 0 && !link.ContainsKey(ClassI.ToLong())) link.Add(ClassI.ToLong(), IssueId); break;
                    case "ClassJ": if (ClassJ.ToLong() != 0 && !link.ContainsKey(ClassJ.ToLong())) link.Add(ClassJ.ToLong(), IssueId); break;
                    case "ClassK": if (ClassK.ToLong() != 0 && !link.ContainsKey(ClassK.ToLong())) link.Add(ClassK.ToLong(), IssueId); break;
                    case "ClassL": if (ClassL.ToLong() != 0 && !link.ContainsKey(ClassL.ToLong())) link.Add(ClassL.ToLong(), IssueId); break;
                    case "ClassM": if (ClassM.ToLong() != 0 && !link.ContainsKey(ClassM.ToLong())) link.Add(ClassM.ToLong(), IssueId); break;
                    case "ClassN": if (ClassN.ToLong() != 0 && !link.ContainsKey(ClassN.ToLong())) link.Add(ClassN.ToLong(), IssueId); break;
                    case "ClassO": if (ClassO.ToLong() != 0 && !link.ContainsKey(ClassO.ToLong())) link.Add(ClassO.ToLong(), IssueId); break;
                    case "ClassP": if (ClassP.ToLong() != 0 && !link.ContainsKey(ClassP.ToLong())) link.Add(ClassP.ToLong(), IssueId); break;
                    case "ClassQ": if (ClassQ.ToLong() != 0 && !link.ContainsKey(ClassQ.ToLong())) link.Add(ClassQ.ToLong(), IssueId); break;
                    case "ClassR": if (ClassR.ToLong() != 0 && !link.ContainsKey(ClassR.ToLong())) link.Add(ClassR.ToLong(), IssueId); break;
                    case "ClassS": if (ClassS.ToLong() != 0 && !link.ContainsKey(ClassS.ToLong())) link.Add(ClassS.ToLong(), IssueId); break;
                    case "ClassT": if (ClassT.ToLong() != 0 && !link.ContainsKey(ClassT.ToLong())) link.Add(ClassT.ToLong(), IssueId); break;
                    case "ClassU": if (ClassU.ToLong() != 0 && !link.ContainsKey(ClassU.ToLong())) link.Add(ClassU.ToLong(), IssueId); break;
                    case "ClassV": if (ClassV.ToLong() != 0 && !link.ContainsKey(ClassV.ToLong())) link.Add(ClassV.ToLong(), IssueId); break;
                    case "ClassW": if (ClassW.ToLong() != 0 && !link.ContainsKey(ClassW.ToLong())) link.Add(ClassW.ToLong(), IssueId); break;
                    case "ClassX": if (ClassX.ToLong() != 0 && !link.ContainsKey(ClassX.ToLong())) link.Add(ClassX.ToLong(), IssueId); break;
                    case "ClassY": if (ClassY.ToLong() != 0 && !link.ContainsKey(ClassY.ToLong())) link.Add(ClassY.ToLong(), IssueId); break;
                    case "ClassZ": if (ClassZ.ToLong() != 0 && !link.ContainsKey(ClassZ.ToLong())) link.Add(ClassZ.ToLong(), IssueId); break;
                    default: break;
                }
            });
            return LinksUtility.Insert(link, selectIdentity);
        }

        private void OnUpdating(ref SqlParamCollection param)
        {
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        private void OnUpdated(ref IssuesResponseCollection responseCollection)
        {
            var column = SiteSettings.AllColumn("RemainingWorkValue");
            responseCollection.Val(
                "#Issues_RemainingWorkValue",
                column.Format(RemainingWorkValue, PermissionType));
        }

        private string ValidateBeforeUpdate()
        {
            if (!PermissionType.CanUpdate())
            {
                return Messages.ResponseHasNotPermission().ToJson();
            }
            foreach(var controlId in Forms.Keys())
            {
                switch (controlId)
                {
                    case "Issues_SiteId": if (!SiteSettings.AllColumn("SiteId").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_UpdatedTime": if (!SiteSettings.AllColumn("UpdatedTime").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_IssueId": if (!SiteSettings.AllColumn("IssueId").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_Ver": if (!SiteSettings.AllColumn("Ver").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_Title": if (!SiteSettings.AllColumn("Title").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_Body": if (!SiteSettings.AllColumn("Body").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_TitleBody": if (!SiteSettings.AllColumn("TitleBody").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_StartTime": if (!SiteSettings.AllColumn("StartTime").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CompletionTime": if (!SiteSettings.AllColumn("CompletionTime").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_WorkValue": if (!SiteSettings.AllColumn("WorkValue").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ProgressRate": if (!SiteSettings.AllColumn("ProgressRate").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_RemainingWorkValue": if (!SiteSettings.AllColumn("RemainingWorkValue").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_Status": if (!SiteSettings.AllColumn("Status").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_Manager": if (!SiteSettings.AllColumn("Manager").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_Owner": if (!SiteSettings.AllColumn("Owner").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassA": if (!SiteSettings.AllColumn("ClassA").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassB": if (!SiteSettings.AllColumn("ClassB").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassC": if (!SiteSettings.AllColumn("ClassC").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassD": if (!SiteSettings.AllColumn("ClassD").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassE": if (!SiteSettings.AllColumn("ClassE").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassF": if (!SiteSettings.AllColumn("ClassF").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassG": if (!SiteSettings.AllColumn("ClassG").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassH": if (!SiteSettings.AllColumn("ClassH").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassI": if (!SiteSettings.AllColumn("ClassI").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassJ": if (!SiteSettings.AllColumn("ClassJ").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassK": if (!SiteSettings.AllColumn("ClassK").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassL": if (!SiteSettings.AllColumn("ClassL").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassM": if (!SiteSettings.AllColumn("ClassM").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassN": if (!SiteSettings.AllColumn("ClassN").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassO": if (!SiteSettings.AllColumn("ClassO").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassP": if (!SiteSettings.AllColumn("ClassP").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassQ": if (!SiteSettings.AllColumn("ClassQ").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassR": if (!SiteSettings.AllColumn("ClassR").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassS": if (!SiteSettings.AllColumn("ClassS").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassT": if (!SiteSettings.AllColumn("ClassT").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassU": if (!SiteSettings.AllColumn("ClassU").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassV": if (!SiteSettings.AllColumn("ClassV").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassW": if (!SiteSettings.AllColumn("ClassW").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassX": if (!SiteSettings.AllColumn("ClassX").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassY": if (!SiteSettings.AllColumn("ClassY").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_ClassZ": if (!SiteSettings.AllColumn("ClassZ").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumA": if (!SiteSettings.AllColumn("NumA").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumB": if (!SiteSettings.AllColumn("NumB").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumC": if (!SiteSettings.AllColumn("NumC").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumD": if (!SiteSettings.AllColumn("NumD").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumE": if (!SiteSettings.AllColumn("NumE").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumF": if (!SiteSettings.AllColumn("NumF").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumG": if (!SiteSettings.AllColumn("NumG").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumH": if (!SiteSettings.AllColumn("NumH").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumI": if (!SiteSettings.AllColumn("NumI").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumJ": if (!SiteSettings.AllColumn("NumJ").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumK": if (!SiteSettings.AllColumn("NumK").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumL": if (!SiteSettings.AllColumn("NumL").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumM": if (!SiteSettings.AllColumn("NumM").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumN": if (!SiteSettings.AllColumn("NumN").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumO": if (!SiteSettings.AllColumn("NumO").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumP": if (!SiteSettings.AllColumn("NumP").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumQ": if (!SiteSettings.AllColumn("NumQ").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumR": if (!SiteSettings.AllColumn("NumR").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumS": if (!SiteSettings.AllColumn("NumS").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumT": if (!SiteSettings.AllColumn("NumT").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumU": if (!SiteSettings.AllColumn("NumU").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumV": if (!SiteSettings.AllColumn("NumV").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumW": if (!SiteSettings.AllColumn("NumW").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumX": if (!SiteSettings.AllColumn("NumX").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumY": if (!SiteSettings.AllColumn("NumY").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_NumZ": if (!SiteSettings.AllColumn("NumZ").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateA": if (!SiteSettings.AllColumn("DateA").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateB": if (!SiteSettings.AllColumn("DateB").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateC": if (!SiteSettings.AllColumn("DateC").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateD": if (!SiteSettings.AllColumn("DateD").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateE": if (!SiteSettings.AllColumn("DateE").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateF": if (!SiteSettings.AllColumn("DateF").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateG": if (!SiteSettings.AllColumn("DateG").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateH": if (!SiteSettings.AllColumn("DateH").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateI": if (!SiteSettings.AllColumn("DateI").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateJ": if (!SiteSettings.AllColumn("DateJ").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateK": if (!SiteSettings.AllColumn("DateK").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateL": if (!SiteSettings.AllColumn("DateL").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateM": if (!SiteSettings.AllColumn("DateM").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateN": if (!SiteSettings.AllColumn("DateN").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateO": if (!SiteSettings.AllColumn("DateO").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateP": if (!SiteSettings.AllColumn("DateP").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateQ": if (!SiteSettings.AllColumn("DateQ").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateR": if (!SiteSettings.AllColumn("DateR").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateS": if (!SiteSettings.AllColumn("DateS").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateT": if (!SiteSettings.AllColumn("DateT").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateU": if (!SiteSettings.AllColumn("DateU").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateV": if (!SiteSettings.AllColumn("DateV").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateW": if (!SiteSettings.AllColumn("DateW").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateX": if (!SiteSettings.AllColumn("DateX").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateY": if (!SiteSettings.AllColumn("DateY").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DateZ": if (!SiteSettings.AllColumn("DateZ").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionA": if (!SiteSettings.AllColumn("DescriptionA").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionB": if (!SiteSettings.AllColumn("DescriptionB").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionC": if (!SiteSettings.AllColumn("DescriptionC").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionD": if (!SiteSettings.AllColumn("DescriptionD").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionE": if (!SiteSettings.AllColumn("DescriptionE").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionF": if (!SiteSettings.AllColumn("DescriptionF").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionG": if (!SiteSettings.AllColumn("DescriptionG").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionH": if (!SiteSettings.AllColumn("DescriptionH").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionI": if (!SiteSettings.AllColumn("DescriptionI").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionJ": if (!SiteSettings.AllColumn("DescriptionJ").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionK": if (!SiteSettings.AllColumn("DescriptionK").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionL": if (!SiteSettings.AllColumn("DescriptionL").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionM": if (!SiteSettings.AllColumn("DescriptionM").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionN": if (!SiteSettings.AllColumn("DescriptionN").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionO": if (!SiteSettings.AllColumn("DescriptionO").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionP": if (!SiteSettings.AllColumn("DescriptionP").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionQ": if (!SiteSettings.AllColumn("DescriptionQ").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionR": if (!SiteSettings.AllColumn("DescriptionR").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionS": if (!SiteSettings.AllColumn("DescriptionS").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionT": if (!SiteSettings.AllColumn("DescriptionT").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionU": if (!SiteSettings.AllColumn("DescriptionU").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionV": if (!SiteSettings.AllColumn("DescriptionV").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionW": if (!SiteSettings.AllColumn("DescriptionW").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionX": if (!SiteSettings.AllColumn("DescriptionX").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionY": if (!SiteSettings.AllColumn("DescriptionY").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_DescriptionZ": if (!SiteSettings.AllColumn("DescriptionZ").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckA": if (!SiteSettings.AllColumn("CheckA").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckB": if (!SiteSettings.AllColumn("CheckB").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckC": if (!SiteSettings.AllColumn("CheckC").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckD": if (!SiteSettings.AllColumn("CheckD").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckE": if (!SiteSettings.AllColumn("CheckE").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckF": if (!SiteSettings.AllColumn("CheckF").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckG": if (!SiteSettings.AllColumn("CheckG").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckH": if (!SiteSettings.AllColumn("CheckH").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckI": if (!SiteSettings.AllColumn("CheckI").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckJ": if (!SiteSettings.AllColumn("CheckJ").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckK": if (!SiteSettings.AllColumn("CheckK").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckL": if (!SiteSettings.AllColumn("CheckL").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckM": if (!SiteSettings.AllColumn("CheckM").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckN": if (!SiteSettings.AllColumn("CheckN").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckO": if (!SiteSettings.AllColumn("CheckO").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckP": if (!SiteSettings.AllColumn("CheckP").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckQ": if (!SiteSettings.AllColumn("CheckQ").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckR": if (!SiteSettings.AllColumn("CheckR").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckS": if (!SiteSettings.AllColumn("CheckS").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckT": if (!SiteSettings.AllColumn("CheckT").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckU": if (!SiteSettings.AllColumn("CheckU").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckV": if (!SiteSettings.AllColumn("CheckV").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckW": if (!SiteSettings.AllColumn("CheckW").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckX": if (!SiteSettings.AllColumn("CheckX").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckY": if (!SiteSettings.AllColumn("CheckY").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CheckZ": if (!SiteSettings.AllColumn("CheckZ").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_Comments": if (!SiteSettings.AllColumn("Comments").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_Creator": if (!SiteSettings.AllColumn("Creator").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_Updator": if (!SiteSettings.AllColumn("Updator").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_CreatedTime": if (!SiteSettings.AllColumn("CreatedTime").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_VerUp": if (!SiteSettings.AllColumn("VerUp").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                    case "Issues_Timestamp": if (!SiteSettings.AllColumn("Timestamp").CanUpdate(PermissionType)) return Messages.ResponseInvalidRequest().ToJson(); break;
                }
            }
            return null;
        }

        private ResponseCollection ResponseByUpdate(IssuesResponseCollection responseCollection)
        {
            return responseCollection
                .Ver()
                .Timestamp()
                .Val("#VerUp", false)
                .FormResponse(this)
                .Formula(this)
                .Disabled("#VerUp", false)
                .Html("#HeaderTitle", Title.DisplayValue)
                .Html("#RecordInfo", new HtmlBuilder().RecordInfo(baseModel: this, tableName: "Issues"))
                .Html("#Links", new HtmlBuilder().Links(IssueId))
                .Message(Messages.Updated(Title.ToString()))
                .RemoveComment(DeleteCommentId, _using: DeleteCommentId != 0)
                .ClearFormData();
        }

        public string UpdateOrCreate(
            SqlWhereCollection where = null,
            SqlParamCollection param = null)
        {
            if (!PermissionType.CanUpdate())
            {
                return Messages.ResponseHasNotPermission().ToJson();
            }
            SetBySession();
            OnUpdatingOrCreating(ref where, ref param);
            var newId = Rds.ExecuteScalar_long(
                transactional: true,
                statements: new SqlStatement[]
                {
                    Rds.InsertItems(
                        selectIdentity: true,
                        param: Rds.ItemsParam()
                            .ReferenceType("Issues")
                            .SiteId(SiteId)
                            .Title(Title.Value)),
                    Rds.UpdateOrInsertIssues(
                        selectIdentity: true,
                        where: where ?? Rds.IssuesWhereDefault(this),
                        param: param ?? Rds.IssuesParamDefault(this, setDefault: true))
                });
            IssueId = newId != 0 ? newId : IssueId;
            Get();
            var responseCollection = new IssuesResponseCollection(this);
            OnUpdatedOrCreated(ref responseCollection);
            return responseCollection.ToJson();
        }

        private void OnUpdatingOrCreating(
            ref SqlWhereCollection where,
            ref SqlParamCollection param)
        {
        }

        private void OnUpdatedOrCreated(ref IssuesResponseCollection responseCollection)
        {
        }

        public string Copy()
        {
            IssueId = 0;
            if (SiteSettings.AllColumn("Title").EditorVisible.ToBool())
            {
                Title.Value += Displays.SuffixCopy();
            }
            if (!Forms.Data("Dialog_ConfirmCopy_WithComments").ToBool())
            {
                Comments.Clear();
            }
            return Create(paramAll: true);
        }

        public string Move()
        {
            var siteId = Forms.Long("Dialog_MoveTargets");
            if (siteId == 0 || !Permissions.CanMove(SiteId, siteId))
            {
                return Messages.ResponseHasNotPermission().ToJson();
            }
            SiteId = siteId;
            Rds.ExecuteNonQuery(statements: new SqlStatement[]
            {
                Rds.UpdateItems(
                    where: Rds.ItemsWhere().ReferenceId(IssueId),
                    param: Rds.ItemsParam().SiteId(SiteId)),
                Rds.UpdateIssues(
                    where: Rds.IssuesWhere().IssueId(IssueId),
                    param: Rds.IssuesParam().SiteId(SiteId))
            });
            return Editor();
        }

        public string Delete(bool redirect = true)
        {
            if (!PermissionType.CanDelete())
            {
                return Messages.ResponseHasNotPermission().ToJson();
            }
            OnDeleting();
            Rds.ExecuteNonQuery(
                transactional: true,
                statements: new SqlStatement[]
                {
                    Rds.DeleteItems(
                        where: Rds.ItemsWhere().ReferenceId(IssueId)),
                    Rds.DeleteIssues(
                        where: Rds.IssuesWhere().SiteId(SiteId).IssueId(IssueId))
                });
            Sessions.Set("Message", Messages.Deleted(Title.Value).Html);
            var responseCollection = new IssuesResponseCollection(this);
            OnDeleted(ref responseCollection);
            if (redirect)
            {
                responseCollection.Href(Navigations.ItemIndex(SiteId));
            }
            return responseCollection.ToJson();
        }

        private void OnDeleting()
        {
        }

        private void OnDeleted(ref IssuesResponseCollection responseCollection)
        {
        }

        public string Restore(long issueId)
        {
            if (!Permissions.Admins().CanEditTenant())
            {
                return Messages.ResponseHasNotPermission().ToJson();
            }
            IssueId = issueId;
            Rds.ExecuteNonQuery(
                connectionString: Parameters.Rds.OwnerConnectionString,
                transactional: true,
                statements: new SqlStatement[]
                {
                    Rds.RestoreItems(
                        where: Rds.ItemsWhere().ReferenceId(IssueId)),
                    Rds.RestoreIssues(
                        where: Rds.IssuesWhere().IssueId(IssueId))
                });
            return new ResponseCollection().ToJson();
        }

        public string PhysicalDelete(Sqls.TableTypes tableType = Sqls.TableTypes.Normal)
        {
            if (!PermissionType.CanDelete())
            {
                return Messages.ResponseHasNotPermission().ToJson();
            }
            OnPhysicalDeleting();
            Rds.ExecuteNonQuery(
                transactional: true,
                statements: Rds.PhysicalDeleteIssues(
                    tableType: tableType,
                    param: Rds.IssuesParam().SiteId(SiteId).IssueId(IssueId)));
            var responseCollection = new IssuesResponseCollection(this);
            OnPhysicalDeleted(ref responseCollection);
            return responseCollection.ToJson();
        }

        private void OnPhysicalDeleting()
        {
        }

        private void OnPhysicalDeleted(ref IssuesResponseCollection responseCollection)
        {
        }

        private void SynchronizeSummary()
        {
            SiteSettings.SummaryCollection.ForEach(summary =>
            {
                var id = SynchronizeSummaryDestinationId(summary.LinkColumn);
                var savedId = SynchronizeSummaryDestinationId(summary.LinkColumn, saved: true);
                if (id != 0)
                {
                    SynchronizeSummary(summary, id);
                }
                if (savedId != 0 && id != savedId)
                {
                    SynchronizeSummary(summary, savedId);
                }
            });
        }

        private void SynchronizeSummary(Summary summary, long id)
        {
            Summaries.Synchronize(
                summary.SiteId,
                summary.DestinationReferenceType,
                summary.DestinationColumn,
                SiteId,
                "Issues",
                summary.LinkColumn,
                summary.Type,
                summary.SourceColumn,
                id);
            Formulas.Update(id);
        }

        private long SynchronizeSummaryDestinationId(string linkColumn, bool saved = false)
        {
            switch (linkColumn)
            {
                case "ClassA": return saved ? SavedClassA.ToLong() : ClassA.ToLong();
                case "ClassB": return saved ? SavedClassB.ToLong() : ClassB.ToLong();
                case "ClassC": return saved ? SavedClassC.ToLong() : ClassC.ToLong();
                case "ClassD": return saved ? SavedClassD.ToLong() : ClassD.ToLong();
                case "ClassE": return saved ? SavedClassE.ToLong() : ClassE.ToLong();
                case "ClassF": return saved ? SavedClassF.ToLong() : ClassF.ToLong();
                case "ClassG": return saved ? SavedClassG.ToLong() : ClassG.ToLong();
                case "ClassH": return saved ? SavedClassH.ToLong() : ClassH.ToLong();
                case "ClassI": return saved ? SavedClassI.ToLong() : ClassI.ToLong();
                case "ClassJ": return saved ? SavedClassJ.ToLong() : ClassJ.ToLong();
                case "ClassK": return saved ? SavedClassK.ToLong() : ClassK.ToLong();
                case "ClassL": return saved ? SavedClassL.ToLong() : ClassL.ToLong();
                case "ClassM": return saved ? SavedClassM.ToLong() : ClassM.ToLong();
                case "ClassN": return saved ? SavedClassN.ToLong() : ClassN.ToLong();
                case "ClassO": return saved ? SavedClassO.ToLong() : ClassO.ToLong();
                case "ClassP": return saved ? SavedClassP.ToLong() : ClassP.ToLong();
                case "ClassQ": return saved ? SavedClassQ.ToLong() : ClassQ.ToLong();
                case "ClassR": return saved ? SavedClassR.ToLong() : ClassR.ToLong();
                case "ClassS": return saved ? SavedClassS.ToLong() : ClassS.ToLong();
                case "ClassT": return saved ? SavedClassT.ToLong() : ClassT.ToLong();
                case "ClassU": return saved ? SavedClassU.ToLong() : ClassU.ToLong();
                case "ClassV": return saved ? SavedClassV.ToLong() : ClassV.ToLong();
                case "ClassW": return saved ? SavedClassW.ToLong() : ClassW.ToLong();
                case "ClassX": return saved ? SavedClassX.ToLong() : ClassX.ToLong();
                case "ClassY": return saved ? SavedClassY.ToLong() : ClassY.ToLong();
                case "ClassZ": return saved ? SavedClassZ.ToLong() : ClassZ.ToLong();
                default: return 0;
            }
        }

        public void UpdateFormulaColumns()
        {
            SetByFormula();
            var param = Rds.IssuesParam();
            SiteSettings.FormulaHash.Keys.ForEach(columnName =>
            {
                switch (columnName)
                {
                    case "WorkValue": param.WorkValue(WorkValue.Value); break;
                    case "NumA": param.NumA(NumA); break;
                    case "NumB": param.NumB(NumB); break;
                    case "NumC": param.NumC(NumC); break;
                    case "NumD": param.NumD(NumD); break;
                    case "NumE": param.NumE(NumE); break;
                    case "NumF": param.NumF(NumF); break;
                    case "NumG": param.NumG(NumG); break;
                    case "NumH": param.NumH(NumH); break;
                    case "NumI": param.NumI(NumI); break;
                    case "NumJ": param.NumJ(NumJ); break;
                    case "NumK": param.NumK(NumK); break;
                    case "NumL": param.NumL(NumL); break;
                    case "NumM": param.NumM(NumM); break;
                    case "NumN": param.NumN(NumN); break;
                    case "NumO": param.NumO(NumO); break;
                    case "NumP": param.NumP(NumP); break;
                    case "NumQ": param.NumQ(NumQ); break;
                    case "NumR": param.NumR(NumR); break;
                    case "NumS": param.NumS(NumS); break;
                    case "NumT": param.NumT(NumT); break;
                    case "NumU": param.NumU(NumU); break;
                    case "NumV": param.NumV(NumV); break;
                    case "NumW": param.NumW(NumW); break;
                    case "NumX": param.NumX(NumX); break;
                    case "NumY": param.NumY(NumY); break;
                    case "NumZ": param.NumZ(NumZ); break;
                    default: break;
                }
            });
            Rds.ExecuteNonQuery(statements:
                Rds.UpdateIssues(
                    param: param,
                    where: Rds.IssuesWhereDefault(this),
                    addUpdatedTimeParam: false,
                    addUpdatorParam: false));
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public string EditSeparateSettings()
        {
            return new ResponseCollection()
                .Html(
                    "#Dialog_SeparateSettings",
                    new HtmlBuilder().SeparateSettings(
                        Title.Value,
                        WorkValue.Value,
                        SiteSettings.AllColumn("WorkValue"),
                        PermissionType))
                .Func("separate")
                .ToJson();
        }

        /// <summary>
        /// Fixed:
        /// </summary>
        public string Separate()
        {
            var number = Forms.Int("SeparateNumber");
            if (number >= 2)
            {
                var idHash = new Dictionary<int, long> { { 1, IssueId } };
                var ver = Ver;
                var timestampHash = new Dictionary<int, string> { { 1, Timestamp } };
                var comments = Comments.ToJson();
                for (var index = 2; index <= number; index++)
                {
                    IssueId = 0;
                    Create(paramAll: true);
                    idHash.Add(index, IssueId);
                    timestampHash.Add(index, Timestamp);
                }
                var addCommentCollection = new List<string> { Displays.Separated() };
                addCommentCollection.AddRange(idHash.Select(o => "[{0}]({1}{2})".Params(
                    Forms.Data("SeparateTitle_" + o.Key),
                    Url.Server(),
                    Navigations.ItemEdit(o.Value))));
                var addComment = addCommentCollection.Join("\n");
                for (var index = number; index >= 1; index--)
                {
                    var source = index == 1;
                    IssueId = idHash[index];
                    Ver = source
                        ? ver
                        : 1;
                    Timestamp = timestampHash[index];
                    Title.Value = Forms.Data("SeparateTitle_" + index);
                    WorkValue.Value = source
                        ? Forms.Decimal("SourceWorkValue")
                        : Forms.Decimal("SeparateWorkValue_" + index);
                    Comments.Clear();
                    if (source || Forms.Bool("SeparateCopyWithComments"))
                    {
                        Comments = comments.Deserialize<Comments>();
                    }
                    Comments.Prepend(addComment);
                    Update(paramAll: true);
                }
                return RecordResponse(this, Messages.Separated());
            }
            else
            {
                return Messages.ResponseInvalidRequest().ToJson();
            }
        }

        public string Histories()
        {
            var hb = new HtmlBuilder();
            hb.Table(
                attributes: new HtmlAttributes().Class("grid"),
                action: () =>
                {
                    hb.GridHeader(
                        columnCollection: SiteSettings.HistoryColumnCollection(),
                        sort: false,
                        checkRow: false);
                    new IssueCollection(
                        siteSettings: SiteSettings,
                        permissionType: PermissionType,
                        where: Rds.IssuesWhere().IssueId(IssueId),
                        orderBy: Rds.IssuesOrderBy().Ver(SqlOrderBy.Types.desc),
                        tableType: Sqls.TableTypes.NormalAndHistory).ForEach(issueModel => hb
                            .Tr(
                                attributes: new HtmlAttributes()
                                    .Class("grid-row history not-link")
                                    .DataAction("History")
                                    .DataMethod("post")
                                    .Add("data-ver", issueModel.Ver)
                                    .Add("data-latest", 1, _using: issueModel.Ver == Ver),
                                action: () =>
                                    SiteSettings.HistoryColumnCollection().ForEach(column =>
                                        hb.TdValue(column, issueModel))));
                });
            return new IssuesResponseCollection(this).Html("#FieldSetHistories", hb).ToJson();
        }

        public string History()
        {
            Get(
                where: Rds.IssuesWhere()
                    .IssueId(IssueId)
                    .Ver(Forms.Int("Ver")),
                tableType: Sqls.TableTypes.NormalAndHistory);
            VerType =  Forms.Bool("Latest")
                ? Versions.VerTypes.Latest
                : Versions.VerTypes.History;
            SwitchTargets = IssuesUtility.GetSwitchTargets(SiteSettings, SiteId);
            return Editor();
        }

        public string Previous()
        {
            var switchTargets = IssuesUtility.GetSwitchTargets(SiteSettings, SiteId);
            var issueModel = new IssueModel(
                siteSettings: SiteSettings,
                permissionType: PermissionType,
                issueId: switchTargets.Previous(IssueId),
                switchTargets: switchTargets);
            return RecordResponse(issueModel);
        }

        public string Next()
        {
            var switchTargets = IssuesUtility.GetSwitchTargets(SiteSettings, SiteId);
            var issueModel = new IssueModel(
                siteSettings: SiteSettings,
                permissionType: PermissionType,
                issueId: switchTargets.Next(IssueId),
                switchTargets: switchTargets);
            return RecordResponse(issueModel);
        }

        public string Reload()
        {
            SwitchTargets = IssuesUtility.GetSwitchTargets(SiteSettings, SiteId);
            return RecordResponse(this, pushState: false);
        }

        private string RecordResponse(
            IssueModel issueModel, Message message = null, bool pushState = true)
        {
            var siteModel = new SiteModel(SiteId);
            issueModel.MethodType = BaseModel.MethodTypes.Edit;
            return new IssuesResponseCollection(this)
                .Func("clearDialogs")
                .Html(
                    "#MainContainer",
                    issueModel.AccessStatus == Databases.AccessStatuses.Selected
                        ? IssuesUtility.Editor(siteModel, issueModel)
                        : IssuesUtility.Editor(siteModel, this))
                .Message(message)
                .PushState(
                    "Edit",
                    Navigations.ItemEdit(issueModel.IssueId),
                    _using: pushState)
                .ClearFormData()
                .ToJson();
        }

        private void SetByForm()
        {
            Forms.Keys().ForEach(controlId =>
            {
                switch (controlId)
                {
                    case "Issues_Title": Title = new Title(IssueId, Forms.Data(controlId)); break;
                    case "Issues_Body": Body = Forms.Data(controlId).ToString(); break;
                    case "Issues_StartTime": StartTime = Forms.DateTime(controlId).ToUniversal(); ProgressRate.StartTime = StartTime; break;
                    case "Issues_CompletionTime": CompletionTime = new CompletionTime(Forms.Data(controlId).ToDateTime(), Status, byForm: true); ProgressRate.CompletionTime = CompletionTime.Value; break;
                    case "Issues_WorkValue": WorkValue = new WorkValue(SiteSettings.AllColumn("WorkValue").Round(Forms.Decimal(controlId)), ProgressRate.Value); break;
                    case "Issues_ProgressRate": ProgressRate = new ProgressRate(CreatedTime, StartTime, CompletionTime, SiteSettings.AllColumn("ProgressRate").Round(Forms.Decimal(controlId))); WorkValue.ProgressRate = ProgressRate.Value; break;
                    case "Issues_Status": Status = new Status(Forms.Data(controlId).ToInt()); CompletionTime.Status = Status; break;
                    case "Issues_Manager": Manager = SiteInfo.User(Forms.Int(controlId)); break;
                    case "Issues_Owner": Owner = SiteInfo.User(Forms.Int(controlId)); break;
                    case "Issues_ClassA": ClassA = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassB": ClassB = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassC": ClassC = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassD": ClassD = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassE": ClassE = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassF": ClassF = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassG": ClassG = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassH": ClassH = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassI": ClassI = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassJ": ClassJ = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassK": ClassK = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassL": ClassL = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassM": ClassM = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassN": ClassN = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassO": ClassO = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassP": ClassP = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassQ": ClassQ = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassR": ClassR = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassS": ClassS = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassT": ClassT = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassU": ClassU = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassV": ClassV = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassW": ClassW = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassX": ClassX = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassY": ClassY = Forms.Data(controlId).ToString(); break;
                    case "Issues_ClassZ": ClassZ = Forms.Data(controlId).ToString(); break;
                    case "Issues_NumA": NumA = SiteSettings.AllColumn("NumA").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumB": NumB = SiteSettings.AllColumn("NumB").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumC": NumC = SiteSettings.AllColumn("NumC").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumD": NumD = SiteSettings.AllColumn("NumD").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumE": NumE = SiteSettings.AllColumn("NumE").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumF": NumF = SiteSettings.AllColumn("NumF").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumG": NumG = SiteSettings.AllColumn("NumG").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumH": NumH = SiteSettings.AllColumn("NumH").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumI": NumI = SiteSettings.AllColumn("NumI").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumJ": NumJ = SiteSettings.AllColumn("NumJ").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumK": NumK = SiteSettings.AllColumn("NumK").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumL": NumL = SiteSettings.AllColumn("NumL").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumM": NumM = SiteSettings.AllColumn("NumM").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumN": NumN = SiteSettings.AllColumn("NumN").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumO": NumO = SiteSettings.AllColumn("NumO").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumP": NumP = SiteSettings.AllColumn("NumP").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumQ": NumQ = SiteSettings.AllColumn("NumQ").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumR": NumR = SiteSettings.AllColumn("NumR").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumS": NumS = SiteSettings.AllColumn("NumS").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumT": NumT = SiteSettings.AllColumn("NumT").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumU": NumU = SiteSettings.AllColumn("NumU").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumV": NumV = SiteSettings.AllColumn("NumV").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumW": NumW = SiteSettings.AllColumn("NumW").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumX": NumX = SiteSettings.AllColumn("NumX").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumY": NumY = SiteSettings.AllColumn("NumY").Round(Forms.Decimal(controlId)); break;
                    case "Issues_NumZ": NumZ = SiteSettings.AllColumn("NumZ").Round(Forms.Decimal(controlId)); break;
                    case "Issues_DateA": DateA = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateB": DateB = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateC": DateC = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateD": DateD = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateE": DateE = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateF": DateF = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateG": DateG = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateH": DateH = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateI": DateI = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateJ": DateJ = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateK": DateK = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateL": DateL = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateM": DateM = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateN": DateN = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateO": DateO = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateP": DateP = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateQ": DateQ = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateR": DateR = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateS": DateS = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateT": DateT = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateU": DateU = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateV": DateV = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateW": DateW = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateX": DateX = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateY": DateY = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DateZ": DateZ = Forms.Data(controlId).ToDateTime().ToUniversal(); break;
                    case "Issues_DescriptionA": DescriptionA = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionB": DescriptionB = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionC": DescriptionC = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionD": DescriptionD = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionE": DescriptionE = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionF": DescriptionF = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionG": DescriptionG = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionH": DescriptionH = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionI": DescriptionI = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionJ": DescriptionJ = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionK": DescriptionK = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionL": DescriptionL = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionM": DescriptionM = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionN": DescriptionN = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionO": DescriptionO = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionP": DescriptionP = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionQ": DescriptionQ = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionR": DescriptionR = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionS": DescriptionS = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionT": DescriptionT = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionU": DescriptionU = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionV": DescriptionV = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionW": DescriptionW = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionX": DescriptionX = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionY": DescriptionY = Forms.Data(controlId).ToString(); break;
                    case "Issues_DescriptionZ": DescriptionZ = Forms.Data(controlId).ToString(); break;
                    case "Issues_CheckA": CheckA = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckB": CheckB = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckC": CheckC = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckD": CheckD = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckE": CheckE = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckF": CheckF = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckG": CheckG = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckH": CheckH = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckI": CheckI = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckJ": CheckJ = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckK": CheckK = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckL": CheckL = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckM": CheckM = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckN": CheckN = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckO": CheckO = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckP": CheckP = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckQ": CheckQ = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckR": CheckR = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckS": CheckS = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckT": CheckT = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckU": CheckU = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckV": CheckV = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckW": CheckW = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckX": CheckX = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckY": CheckY = Forms.Data(controlId).ToBool(); break;
                    case "Issues_CheckZ": CheckZ = Forms.Data(controlId).ToBool(); break;
                    case "Issues_Timestamp": Timestamp = Forms.Data(controlId).ToString(); break;
                    case "Comments": Comments = Comments.Prepend(Forms.Data("Comments")); break;
                    case "VerUp": VerUp = Forms.Data(controlId).ToBool(); break;
                    default: break;
                }
            });
            if (Routes.Action() == "deletecomment")
            {
                DeleteCommentId = Forms.Data("ControlId").Split(',')._2nd().ToInt();
                Comments.RemoveAll(o => o.CommentId == DeleteCommentId);
            }
            Forms.FileKeys().ForEach(controlId =>
            {
                switch (controlId)
                {
                    default: break;
                }
            });
            SetByFormula();
        }

        private void SetByFormula()
        {
            if (SiteSettings.FormulaHash?.Count > 0)
            {
                var data = new Dictionary<string, decimal>
                {
                    { "WorkValue", WorkValue.Value },
                    { "RemainingWorkValue", RemainingWorkValue },
                    { "NumA", NumA },
                    { "NumB", NumB },
                    { "NumC", NumC },
                    { "NumD", NumD },
                    { "NumE", NumE },
                    { "NumF", NumF },
                    { "NumG", NumG },
                    { "NumH", NumH },
                    { "NumI", NumI },
                    { "NumJ", NumJ },
                    { "NumK", NumK },
                    { "NumL", NumL },
                    { "NumM", NumM },
                    { "NumN", NumN },
                    { "NumO", NumO },
                    { "NumP", NumP },
                    { "NumQ", NumQ },
                    { "NumR", NumR },
                    { "NumS", NumS },
                    { "NumT", NumT },
                    { "NumU", NumU },
                    { "NumV", NumV },
                    { "NumW", NumW },
                    { "NumX", NumX },
                    { "NumY", NumY },
                    { "NumZ", NumZ }
                };
                SiteSettings.FormulaHash.Keys.ForEach(columnName =>
                {
                    switch (columnName)
                    {
                        case "WorkValue": WorkValue.Value = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumA": NumA = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumB": NumB = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumC": NumC = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumD": NumD = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumE": NumE = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumF": NumF = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumG": NumG = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumH": NumH = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumI": NumI = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumJ": NumJ = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumK": NumK = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumL": NumL = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumM": NumM = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumN": NumN = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumO": NumO = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumP": NumP = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumQ": NumQ = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumR": NumR = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumS": NumS = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumT": NumT = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumU": NumU = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumV": NumV = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumW": NumW = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumX": NumX = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumY": NumY = SiteSettings.FormulaResult(columnName, data); break;
                        case "NumZ": NumZ = SiteSettings.FormulaResult(columnName, data); break;
                        default: break;
                    }
                });
            }
        }

        private void SetBySession()
        {
        }

        private void Set(DataTable dataTable)
        {
            switch (dataTable.Rows.Count)
            {
                case 1: Set(dataTable.Rows[0]); break;
                case 0: AccessStatus = Databases.AccessStatuses.NotFound; break;
                default: AccessStatus = Databases.AccessStatuses.Overlap; break;
            }
        }

        private void Set(DataRow dataRow)
        {
            AccessStatus = Databases.AccessStatuses.Selected;
            foreach(DataColumn dataColumn in dataRow.Table.Columns)
            {
                var name = dataColumn.ColumnName;
                switch(name)
                {
                    case "SiteId": if (dataRow[name] != DBNull.Value) { SiteId = dataRow[name].ToLong(); SavedSiteId = SiteId; } break;
                    case "UpdatedTime": if (dataRow[name] != DBNull.Value) { UpdatedTime = new Time(dataRow, "UpdatedTime"); Timestamp = dataRow.Field<DateTime>("UpdatedTime").ToString("yyyy/M/d H:m:s.fff"); SavedUpdatedTime = UpdatedTime.Value; } break;
                    case "IssueId": if (dataRow[name] != DBNull.Value) { IssueId = dataRow[name].ToLong(); SavedIssueId = IssueId; } break;
                    case "Ver": Ver = dataRow[name].ToInt(); SavedVer = Ver; break;
                    case "Title": Title = new Title(dataRow, "IssueId"); SavedTitle = Title.Value; break;
                    case "Body": Body = dataRow[name].ToString(); SavedBody = Body; break;
                    case "StartTime": StartTime = dataRow[name].ToDateTime(); SavedStartTime = StartTime; break;
                    case "CompletionTime": CompletionTime = new CompletionTime(dataRow, "CompletionTime"); SavedCompletionTime = CompletionTime.Value; break;
                    case "WorkValue": WorkValue = new WorkValue(dataRow); SavedWorkValue = WorkValue.Value; break;
                    case "ProgressRate": ProgressRate = new ProgressRate(dataRow); SavedProgressRate = ProgressRate.Value; break;
                    case "RemainingWorkValue": RemainingWorkValue = dataRow[name].ToDecimal(); SavedRemainingWorkValue = RemainingWorkValue; break;
                    case "Status": Status = new Status(dataRow, "Status"); SavedStatus = Status.Value; break;
                    case "Manager": Manager = SiteInfo.User(dataRow.Int(name)); SavedManager = Manager.Id; break;
                    case "Owner": Owner = SiteInfo.User(dataRow.Int(name)); SavedOwner = Owner.Id; break;
                    case "ClassA": ClassA = dataRow[name].ToString(); SavedClassA = ClassA; break;
                    case "ClassB": ClassB = dataRow[name].ToString(); SavedClassB = ClassB; break;
                    case "ClassC": ClassC = dataRow[name].ToString(); SavedClassC = ClassC; break;
                    case "ClassD": ClassD = dataRow[name].ToString(); SavedClassD = ClassD; break;
                    case "ClassE": ClassE = dataRow[name].ToString(); SavedClassE = ClassE; break;
                    case "ClassF": ClassF = dataRow[name].ToString(); SavedClassF = ClassF; break;
                    case "ClassG": ClassG = dataRow[name].ToString(); SavedClassG = ClassG; break;
                    case "ClassH": ClassH = dataRow[name].ToString(); SavedClassH = ClassH; break;
                    case "ClassI": ClassI = dataRow[name].ToString(); SavedClassI = ClassI; break;
                    case "ClassJ": ClassJ = dataRow[name].ToString(); SavedClassJ = ClassJ; break;
                    case "ClassK": ClassK = dataRow[name].ToString(); SavedClassK = ClassK; break;
                    case "ClassL": ClassL = dataRow[name].ToString(); SavedClassL = ClassL; break;
                    case "ClassM": ClassM = dataRow[name].ToString(); SavedClassM = ClassM; break;
                    case "ClassN": ClassN = dataRow[name].ToString(); SavedClassN = ClassN; break;
                    case "ClassO": ClassO = dataRow[name].ToString(); SavedClassO = ClassO; break;
                    case "ClassP": ClassP = dataRow[name].ToString(); SavedClassP = ClassP; break;
                    case "ClassQ": ClassQ = dataRow[name].ToString(); SavedClassQ = ClassQ; break;
                    case "ClassR": ClassR = dataRow[name].ToString(); SavedClassR = ClassR; break;
                    case "ClassS": ClassS = dataRow[name].ToString(); SavedClassS = ClassS; break;
                    case "ClassT": ClassT = dataRow[name].ToString(); SavedClassT = ClassT; break;
                    case "ClassU": ClassU = dataRow[name].ToString(); SavedClassU = ClassU; break;
                    case "ClassV": ClassV = dataRow[name].ToString(); SavedClassV = ClassV; break;
                    case "ClassW": ClassW = dataRow[name].ToString(); SavedClassW = ClassW; break;
                    case "ClassX": ClassX = dataRow[name].ToString(); SavedClassX = ClassX; break;
                    case "ClassY": ClassY = dataRow[name].ToString(); SavedClassY = ClassY; break;
                    case "ClassZ": ClassZ = dataRow[name].ToString(); SavedClassZ = ClassZ; break;
                    case "NumA": NumA = dataRow[name].ToDecimal(); SavedNumA = NumA; break;
                    case "NumB": NumB = dataRow[name].ToDecimal(); SavedNumB = NumB; break;
                    case "NumC": NumC = dataRow[name].ToDecimal(); SavedNumC = NumC; break;
                    case "NumD": NumD = dataRow[name].ToDecimal(); SavedNumD = NumD; break;
                    case "NumE": NumE = dataRow[name].ToDecimal(); SavedNumE = NumE; break;
                    case "NumF": NumF = dataRow[name].ToDecimal(); SavedNumF = NumF; break;
                    case "NumG": NumG = dataRow[name].ToDecimal(); SavedNumG = NumG; break;
                    case "NumH": NumH = dataRow[name].ToDecimal(); SavedNumH = NumH; break;
                    case "NumI": NumI = dataRow[name].ToDecimal(); SavedNumI = NumI; break;
                    case "NumJ": NumJ = dataRow[name].ToDecimal(); SavedNumJ = NumJ; break;
                    case "NumK": NumK = dataRow[name].ToDecimal(); SavedNumK = NumK; break;
                    case "NumL": NumL = dataRow[name].ToDecimal(); SavedNumL = NumL; break;
                    case "NumM": NumM = dataRow[name].ToDecimal(); SavedNumM = NumM; break;
                    case "NumN": NumN = dataRow[name].ToDecimal(); SavedNumN = NumN; break;
                    case "NumO": NumO = dataRow[name].ToDecimal(); SavedNumO = NumO; break;
                    case "NumP": NumP = dataRow[name].ToDecimal(); SavedNumP = NumP; break;
                    case "NumQ": NumQ = dataRow[name].ToDecimal(); SavedNumQ = NumQ; break;
                    case "NumR": NumR = dataRow[name].ToDecimal(); SavedNumR = NumR; break;
                    case "NumS": NumS = dataRow[name].ToDecimal(); SavedNumS = NumS; break;
                    case "NumT": NumT = dataRow[name].ToDecimal(); SavedNumT = NumT; break;
                    case "NumU": NumU = dataRow[name].ToDecimal(); SavedNumU = NumU; break;
                    case "NumV": NumV = dataRow[name].ToDecimal(); SavedNumV = NumV; break;
                    case "NumW": NumW = dataRow[name].ToDecimal(); SavedNumW = NumW; break;
                    case "NumX": NumX = dataRow[name].ToDecimal(); SavedNumX = NumX; break;
                    case "NumY": NumY = dataRow[name].ToDecimal(); SavedNumY = NumY; break;
                    case "NumZ": NumZ = dataRow[name].ToDecimal(); SavedNumZ = NumZ; break;
                    case "DateA": DateA = dataRow[name].ToDateTime(); SavedDateA = DateA; break;
                    case "DateB": DateB = dataRow[name].ToDateTime(); SavedDateB = DateB; break;
                    case "DateC": DateC = dataRow[name].ToDateTime(); SavedDateC = DateC; break;
                    case "DateD": DateD = dataRow[name].ToDateTime(); SavedDateD = DateD; break;
                    case "DateE": DateE = dataRow[name].ToDateTime(); SavedDateE = DateE; break;
                    case "DateF": DateF = dataRow[name].ToDateTime(); SavedDateF = DateF; break;
                    case "DateG": DateG = dataRow[name].ToDateTime(); SavedDateG = DateG; break;
                    case "DateH": DateH = dataRow[name].ToDateTime(); SavedDateH = DateH; break;
                    case "DateI": DateI = dataRow[name].ToDateTime(); SavedDateI = DateI; break;
                    case "DateJ": DateJ = dataRow[name].ToDateTime(); SavedDateJ = DateJ; break;
                    case "DateK": DateK = dataRow[name].ToDateTime(); SavedDateK = DateK; break;
                    case "DateL": DateL = dataRow[name].ToDateTime(); SavedDateL = DateL; break;
                    case "DateM": DateM = dataRow[name].ToDateTime(); SavedDateM = DateM; break;
                    case "DateN": DateN = dataRow[name].ToDateTime(); SavedDateN = DateN; break;
                    case "DateO": DateO = dataRow[name].ToDateTime(); SavedDateO = DateO; break;
                    case "DateP": DateP = dataRow[name].ToDateTime(); SavedDateP = DateP; break;
                    case "DateQ": DateQ = dataRow[name].ToDateTime(); SavedDateQ = DateQ; break;
                    case "DateR": DateR = dataRow[name].ToDateTime(); SavedDateR = DateR; break;
                    case "DateS": DateS = dataRow[name].ToDateTime(); SavedDateS = DateS; break;
                    case "DateT": DateT = dataRow[name].ToDateTime(); SavedDateT = DateT; break;
                    case "DateU": DateU = dataRow[name].ToDateTime(); SavedDateU = DateU; break;
                    case "DateV": DateV = dataRow[name].ToDateTime(); SavedDateV = DateV; break;
                    case "DateW": DateW = dataRow[name].ToDateTime(); SavedDateW = DateW; break;
                    case "DateX": DateX = dataRow[name].ToDateTime(); SavedDateX = DateX; break;
                    case "DateY": DateY = dataRow[name].ToDateTime(); SavedDateY = DateY; break;
                    case "DateZ": DateZ = dataRow[name].ToDateTime(); SavedDateZ = DateZ; break;
                    case "DescriptionA": DescriptionA = dataRow[name].ToString(); SavedDescriptionA = DescriptionA; break;
                    case "DescriptionB": DescriptionB = dataRow[name].ToString(); SavedDescriptionB = DescriptionB; break;
                    case "DescriptionC": DescriptionC = dataRow[name].ToString(); SavedDescriptionC = DescriptionC; break;
                    case "DescriptionD": DescriptionD = dataRow[name].ToString(); SavedDescriptionD = DescriptionD; break;
                    case "DescriptionE": DescriptionE = dataRow[name].ToString(); SavedDescriptionE = DescriptionE; break;
                    case "DescriptionF": DescriptionF = dataRow[name].ToString(); SavedDescriptionF = DescriptionF; break;
                    case "DescriptionG": DescriptionG = dataRow[name].ToString(); SavedDescriptionG = DescriptionG; break;
                    case "DescriptionH": DescriptionH = dataRow[name].ToString(); SavedDescriptionH = DescriptionH; break;
                    case "DescriptionI": DescriptionI = dataRow[name].ToString(); SavedDescriptionI = DescriptionI; break;
                    case "DescriptionJ": DescriptionJ = dataRow[name].ToString(); SavedDescriptionJ = DescriptionJ; break;
                    case "DescriptionK": DescriptionK = dataRow[name].ToString(); SavedDescriptionK = DescriptionK; break;
                    case "DescriptionL": DescriptionL = dataRow[name].ToString(); SavedDescriptionL = DescriptionL; break;
                    case "DescriptionM": DescriptionM = dataRow[name].ToString(); SavedDescriptionM = DescriptionM; break;
                    case "DescriptionN": DescriptionN = dataRow[name].ToString(); SavedDescriptionN = DescriptionN; break;
                    case "DescriptionO": DescriptionO = dataRow[name].ToString(); SavedDescriptionO = DescriptionO; break;
                    case "DescriptionP": DescriptionP = dataRow[name].ToString(); SavedDescriptionP = DescriptionP; break;
                    case "DescriptionQ": DescriptionQ = dataRow[name].ToString(); SavedDescriptionQ = DescriptionQ; break;
                    case "DescriptionR": DescriptionR = dataRow[name].ToString(); SavedDescriptionR = DescriptionR; break;
                    case "DescriptionS": DescriptionS = dataRow[name].ToString(); SavedDescriptionS = DescriptionS; break;
                    case "DescriptionT": DescriptionT = dataRow[name].ToString(); SavedDescriptionT = DescriptionT; break;
                    case "DescriptionU": DescriptionU = dataRow[name].ToString(); SavedDescriptionU = DescriptionU; break;
                    case "DescriptionV": DescriptionV = dataRow[name].ToString(); SavedDescriptionV = DescriptionV; break;
                    case "DescriptionW": DescriptionW = dataRow[name].ToString(); SavedDescriptionW = DescriptionW; break;
                    case "DescriptionX": DescriptionX = dataRow[name].ToString(); SavedDescriptionX = DescriptionX; break;
                    case "DescriptionY": DescriptionY = dataRow[name].ToString(); SavedDescriptionY = DescriptionY; break;
                    case "DescriptionZ": DescriptionZ = dataRow[name].ToString(); SavedDescriptionZ = DescriptionZ; break;
                    case "CheckA": CheckA = dataRow[name].ToBool(); SavedCheckA = CheckA; break;
                    case "CheckB": CheckB = dataRow[name].ToBool(); SavedCheckB = CheckB; break;
                    case "CheckC": CheckC = dataRow[name].ToBool(); SavedCheckC = CheckC; break;
                    case "CheckD": CheckD = dataRow[name].ToBool(); SavedCheckD = CheckD; break;
                    case "CheckE": CheckE = dataRow[name].ToBool(); SavedCheckE = CheckE; break;
                    case "CheckF": CheckF = dataRow[name].ToBool(); SavedCheckF = CheckF; break;
                    case "CheckG": CheckG = dataRow[name].ToBool(); SavedCheckG = CheckG; break;
                    case "CheckH": CheckH = dataRow[name].ToBool(); SavedCheckH = CheckH; break;
                    case "CheckI": CheckI = dataRow[name].ToBool(); SavedCheckI = CheckI; break;
                    case "CheckJ": CheckJ = dataRow[name].ToBool(); SavedCheckJ = CheckJ; break;
                    case "CheckK": CheckK = dataRow[name].ToBool(); SavedCheckK = CheckK; break;
                    case "CheckL": CheckL = dataRow[name].ToBool(); SavedCheckL = CheckL; break;
                    case "CheckM": CheckM = dataRow[name].ToBool(); SavedCheckM = CheckM; break;
                    case "CheckN": CheckN = dataRow[name].ToBool(); SavedCheckN = CheckN; break;
                    case "CheckO": CheckO = dataRow[name].ToBool(); SavedCheckO = CheckO; break;
                    case "CheckP": CheckP = dataRow[name].ToBool(); SavedCheckP = CheckP; break;
                    case "CheckQ": CheckQ = dataRow[name].ToBool(); SavedCheckQ = CheckQ; break;
                    case "CheckR": CheckR = dataRow[name].ToBool(); SavedCheckR = CheckR; break;
                    case "CheckS": CheckS = dataRow[name].ToBool(); SavedCheckS = CheckS; break;
                    case "CheckT": CheckT = dataRow[name].ToBool(); SavedCheckT = CheckT; break;
                    case "CheckU": CheckU = dataRow[name].ToBool(); SavedCheckU = CheckU; break;
                    case "CheckV": CheckV = dataRow[name].ToBool(); SavedCheckV = CheckV; break;
                    case "CheckW": CheckW = dataRow[name].ToBool(); SavedCheckW = CheckW; break;
                    case "CheckX": CheckX = dataRow[name].ToBool(); SavedCheckX = CheckX; break;
                    case "CheckY": CheckY = dataRow[name].ToBool(); SavedCheckY = CheckY; break;
                    case "CheckZ": CheckZ = dataRow[name].ToBool(); SavedCheckZ = CheckZ; break;
                    case "Comments": Comments = dataRow["Comments"].ToString().Deserialize<Comments>() ?? new Comments(); SavedComments = Comments.ToJson(); break;
                    case "Creator": Creator = SiteInfo.User(dataRow.Int(name)); SavedCreator = Creator.Id; break;
                    case "Updator": Updator = SiteInfo.User(dataRow.Int(name)); SavedUpdator = Updator.Id; break;
                    case "CreatedTime": CreatedTime = new Time(dataRow, "CreatedTime"); SavedCreatedTime = CreatedTime.Value; break;
                    case "IsHistory": VerType = dataRow[name].ToBool() ? Versions.VerTypes.History : Versions.VerTypes.Latest; break;
                }
            }
            if (SiteSettings != null)
            {
                Title.DisplayValue = IssuesUtility.TitleDisplayValue(SiteSettings, this);
            }
        }

        private string Editor()
        {
            var siteModel = new SiteModel(SiteId);
            return new IssuesResponseCollection(this)
                .Html("#MainContainer", IssuesUtility.Editor(siteModel, this))
                .ToJson();
        }

        private string ResponseConflicts()
        {
            Get();
            return AccessStatus == Databases.AccessStatuses.Selected
                ? Messages.ResponseUpdateConflicts(Updator.FullName).ToJson()
                : Messages.ResponseDeleteConflicts().ToJson();
        }
    }
}