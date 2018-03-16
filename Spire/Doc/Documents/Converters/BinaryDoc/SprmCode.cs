﻿namespace Spire.Doc.Documents.Converters.BinaryDoc
{
    using System;

    internal enum SprmCode
    {
        CBrc = 0x6865,
        CBrcEx = 0xca72,
        CCharacterRsid = 0x6815,
        CCharScale = 0x4852,
        CChs = 0xea08,
        CCnf = 0xca85,
        CCv = 0x6870,
        CDefault = 0x2a32,
        CDispFldRMark = 0xca62,
        CDttmRMark = 0x6805,
        CDttmRMarkDel = 0x6864,
        CDxaSpace = 0x8840,
        CFBiDi = 0x85a,
        CFBold = 0x835,
        CFBoldBi = 0x85c,
        CFCaps = 0x83b,
        CFComplexScript = 0x882,
        CFData = 0x806,
        CFDiacColor = 0x85b,
        CFDStrike = 0x2a53,
        CFELayout = 0xca78,
        CFEmboss = 0x858,
        CFFldVanish = 0x802,
        CFFtcAsciSymb = 0x2a10,
        CFImprint = 0x854,
        CFItalic = 0x836,
        CFItalicBi = 0x85d,
        CFMathPr = 0xc81a,
        CFNoProof = 0x875,
        CFObj = 0x856,
        CFOle2 = 0x80a,
        CFOutline = 0x838,
        CFRMarkDel = 0x800,
        CFRMarkIns = 0x801,
        CFSdtVanish = 0x2a90,
        CFShadow = 0x839,
        CFSmallCaps = 0x83a,
        CFSpec = 0x855,
        CFSpecVanish = 0x818,
        CFStrike = 0x837,
        CFtcAscii = 0x4a4f,
        CFtcBi = 0x4a5e,
        CFtcDefault = 0x4a3d,
        CFtcFarEast = 0x4a50,
        CFtcOther = 0x4a51,
        CFUsePgsuSettings = 0x868,
        CFVanish = 0x83c,
        CFWebHidden = 0x811,
        CHighlight = 0x2a0c,
        CHps = 0x4a43,
        CHpsBi = 0x4a61,
        CHpsInc = 0x2a44,
        CHpsInc1 = 0xca4a,
        CHpsKern = 0x484b,
        CHpsMul = 0x4a4d,
        CHpsNew50 = 0xca49,
        CHpsPos = 0x4845,
        CHpsPosAdj = 0x2a46,
        CIbstRMark = 0x4804,
        CIbstRMarkDel = 0x4863,
        CIco = 0x2a42,
        CIcoBi = 0x4a60,
        CIdCharType = 0x480b,
        CIdctHint = 0x286f,
        CIdslRMark = 0x4807,
        CIdslRMarkDel = 0x4867,
        CInsertRsid = 0x6816,
        CIss = 0x2a48,
        CIstd = 0x4a30,
        CIstdPermute = 0xca31,
        CKcd = 0x2a34,
        CKul = 0x2a3e,
        CLid = 0x4873,
        CLid_60 = 0x4a41,
        CLid_80 = 0x486d,
        CLidBi = 0x485f,
        CLidFarEast = 0x4874,
        CLidFarEast_80 = 0x486e,
        CLidUndocumented3 = 0x486b,
        CLineBreakClear = 0x2879,
        CMajority = 0xca47,
        CMajority50 = 0xca4c,
        CNeedFontFixup = 0x2a86,
        CObjLocation = 0x680e,
        CPbiGrf = 0x4888,
        CPbiIBullet = 0x6887,
        CPicLocation = 0x6a03,
        CPlain = 0x2a33,
        CPropRMark = 0xca89,
        CPropRMarkOld = 0xca57,
        CRsidRMDel = 0x6817,
        CSfxText = 0x2859,
        CShd = 0x4866,
        CShdEx = 0xca71,
        CSizePos = 0xea3f,
        CSymbol = 0x6a09,
        CUnderlineColor = 0x6877,
        CWall = 0x2a83,
        CYsri = 0x484e,
        Noop = 0,
        PAnld = 0xc63e,
        PAnldCv = 0x6654,
        PBrcBar = 0x6629,
        PBrcBar10 = 0x4621,
        PBrcBar70 = 0x4629,
        PBrcBarEx = 0xc653,
        PBrcBetween = 0x6428,
        PBrcBetween10 = 0x4620,
        PBrcBetween70 = 0x4428,
        PBrcBetweenEx = 0xc652,
        PBrcBottom = 0x6426,
        PBrcBottom10 = 0x461e,
        PBrcBottom70 = 0x4426,
        PBrcBottomEx = 0xc650,
        PBrcl = 0x2408,
        PBrcLeft = 0x6425,
        PBrcLeft10 = 0x461d,
        PBrcLeft70 = 0x4425,
        PBrcLeftEx = 0xc64f,
        PBrcp = 0x2409,
        PBrcRight = 0x6427,
        PBrcRight10 = 0x461f,
        PBrcRight70 = 0x4427,
        PBrcRightEx = 0xc651,
        PBrcTop = 0x6424,
        PBrcTop10 = 0x461c,
        PBrcTop70 = 0x4424,
        PBrcTopEx = 0xc64e,
        PChgTabs = 0xc60d,
        PChgTabsWithTolerance = 0xc615,
        PCnf = 0xc666,
        PCrLf = 0x2444,
        PDcs = 0x442c,
        PDtap = 0x664a,
        PDxaAbs = 0x8418,
        PDxaFromText = 0x842f,
        PDxaFromText10 = 0x4622,
        PDxaLeft = 0x845e,
        PDxaLeft1 = 0x8460,
        PDxaLeft180 = 0x8411,
        PDxaLeft80 = 0x840f,
        PDxaRight = 0x845d,
        PDxaRight80 = 0x840e,
        PDxaWidth = 0x841a,
        PDxcLeft = 0x4456,
        PDxcLeft1 = 0x4457,
        PDxcRight = 0x4455,
        PDyaAbs = 0x8419,
        PDyaAfter = 0xa414,
        PDyaBefore = 0xa413,
        PDyaBeforeNotCp0 = 0xa46a,
        PDyaFromText = 0x842e,
        PDyaLine = 0x6412,
        PDylAfter = 0x4459,
        PDylBefore = 0x4458,
        PFAdjustRight = 0x2448,
        PFAfterAuto = 0x245c,
        PFAutoSpaceDE = 0x2437,
        PFAutoSpaceDN = 0x2438,
        PFBeforeAuto = 0x245b,
        PFBiDi = 0x2441,
        PFInTable = 0x2416,
        PFKeep = 0x2405,
        PFKeepFollow = 0x2406,
        PFKinsoku = 0x2433,
        PFLockAnchor = 0x2430,
        PFMirrorIndents = 0x2470,
        PFNoAllowOverlap = 0x2462,
        PFNoAutoHyph = 0x242a,
        PFNoLineNumb = 0x240c,
        PFNumRMIns = 0x2443,
        PFOverflowPunct = 0x2435,
        PFPageBreakBefore = 0x2407,
        PFrameTextFlow = 0x443a,
        PFSideBySide = 0x2404,
        PFTopLinePunct = 0x2436,
        PFTtp = 0x2417,
        PFUsePgsuSettings = 0x2447,
        PFWidowControl = 0x2431,
        PFWordWrap = 0x2434,
        PHugePapx = 0x6646,
        PicBrcBottom = 0x6c04,
        PicBrcl = 0x2e00,
        PicBrcLeft = 0x6c03,
        PicBrcRight = 0x6c05,
        PicBrcTop = 0x6c02,
        PicScale = 0xce01,
        PIlfo = 0x460b,
        PIlvl = 0x260a,
        PIncLvl = 0x2602,
        PIpgp = 0x6465,
        PISnapBaseLine = 0x243b,
        PIstd = 0x4600,
        PIstdList = 0x4468,
        PIstdListPermute = 0xc669,
        PIstdPermute = 0xc601,
        PItap = 0x6649,
        PJc = 0x2403,
        PJcEx = 0x2461,
        PNest = 0x4610,
        PNestEx = 0x465f,
        PNLvlAnmFake = 0x25ff,
        PNoSpaceBetweenSameStyle = 0x246d,
        PNumRM = 0xc645,
        POutLvl = 0x2640,
        PPc = 0x261b,
        PPropRMark = 0xc66f,
        PPropRMarkOld = 0xc63f,
        PRpf = 0x246e,
        PRsid = 0x6467,
        PRuler = 0xc632,
        PShd = 0x442d,
        PShdEx = 0xc64d,
        PSubTableEndOfCell = 0x244b,
        PSubTableEndOfRow = 0x244c,
        PTableProps = 0x646b,
        PTIstdInfo = 0xc66c,
        PWAlignFont = 0x4439,
        PWall = 0x2664,
        PWHeightAbs = 0x442b,
        PWr = 0x2423,
        SBkc = 0x3009,
        SBOrientation = 0x301d,
        SBrcBottom = 0x702d,
        SBrcBottomEx = 0xd236,
        SBrcLeft = 0x702c,
        SBrcLeftEx = 0xd235,
        SBrcRight = 0x702e,
        SBrcRightEx = 0xd237,
        SBrcTop = 0x702b,
        SBrcTopEx = 0xd234,
        SClm = 0x5032,
        ScnsPgn = 0x3000,
        SColumns = 0x500b,
        SDmBinFirst = 0x5007,
        SDmBinOther = 0x5008,
        SDmPaperReq = 0x5026,
        SDxaColSpacing = 0xf204,
        SDxaColumns = 0x900c,
        SDxaColWidth = 0xf203,
        SDxaLeft = 0xb021,
        SDxaLnn = 0x9016,
        SDxaRight = 0xb022,
        SDxtCharSpace = 0x7030,
        SDyaBottom = 0x9024,
        SDyaHdrBottom = 0xb018,
        SDyaHdrTop = 0xb017,
        SDyaLinePitch = 0x9031,
        SDyaTop = 0x9023,
        SDzaGutter = 0xb025,
        SFAutoPgn = 0x300d,
        SFBiDi = 0x3228,
        SFEndnote = 0x3012,
        SFEvenlySpaced = 0x3005,
        SFpc = 0x303b,
        SFPgnRestart = 0x3011,
        SFProtected = 0x3006,
        SFRTLGutter = 0x322a,
        SFTitlePage = 0x300a,
        SGprfIhdt = 0x3014,
        SHeadingPgn = 0x3001,
        SLBetween = 0x3019,
        SLnc = 0x3013,
        SLnnMin = 0x501b,
        SNEdn = 0x5041,
        SNfcEdnRef = 0x5042,
        SNfcFtnRef = 0x5040,
        SNfcPgn = 0x300e,
        SNFtn = 0x503f,
        SNLnnMod = 0x5015,
        SPgbProp = 0x522f,
        SPgnStart = 0x7044,
        SPgnStart97 = 0x501c,
        SPropRMark = 0xd243,
        SRncEdn = 0x303e,
        SRncFtn = 0x303c,
        SRsid = 0x703a,
        STextFlow = 0x5033,
        SVjc = 0x301a,
        SWall = 0x3239,
        SXaPage = 0xb01f,
        SYaPage = 0xb020,
        TBrcBottomCv = 0xd61c,
        TBrcLeftCv = 0xd61b,
        TBrcRightCv = 0xd61d,
        TBrcTopCv = 0xd61a,
        TCellBrcBottomStyle = 0xd680,
        TCellBrcInsideHStyle = 0xd683,
        TCellBrcInsideVStyle = 0xd684,
        TCellBrcLeftStyle = 0xd681,
        TCellBrcRightStyle = 0xd682,
        TCellBrcTL2BRStyle = 0xd685,
        TCellBrcTopStyle = 0xd47f,
        TCellBrcTR2BLStyle = 0xd686,
        TCellBrcType = 0xd662,
        TCellHideMark = 0xd642,
        TCellPadding = 0xd632,
        TCellPaddingDefault = 0xd634,
        TCellShd = 0xd609,
        TCellShdEx = 0xd612,
        TCellShdEx2 = 0xd616,
        TCellShdEx3 = 0xd60c,
        TCellShdExRaw = 0xd670,
        TCellShdExRaw2 = 0xd671,
        TCellShdExRaw3 = 0xd672,
        TCellShdStyle = 0xd687,
        TCellSpacingDefault = 0xd633,
        TCellVertAlignStyle = 0x347c,
        TCellWidth = 0xd635,
        TCHorzBands = 0x3488,
        TCnf = 0xd66a,
        TCVertBands = 0x3489,
        TDefTable = 0xd608,
        TDefTable10 = 0xd606,
        TDelete = 0x5622,
        TDiagLine = 0xd62a,
        TDxaCol = 0x7623,
        TDxaGapHalf = 0x9602,
        TDxaLeft = 0x9601,
        TDyaRowHeight = 0x9407,
        TFAllowAutoFit = 0x3615,
        TFBiDi = 0x560b,
        TFCantOverlap = 0x3465,
        TFCantSplit = 0x3466,
        TFCantSplit90 = 0x3403,
        TFCellNoWrap = 0xd639,
        TFitText = 0xf636,
        TFrameLeft = 0x940e,
        TFrameTop = 0x940f,
        TFromTextBottom = 0x941f,
        TFromTextLeft = 0x9410,
        TFromTextRight = 0x941e,
        TFromTextTop = 0x9411,
        THTMLProps = 0x740c,
        TInsert = 0x7621,
        TIpgp = 0x7469,
        TIstd = 0x563a,
        TJc = 0x5400,
        TJcEx = 0x548a,
        TLeftIndent = 0xf661,
        TMerge = 0x5624,
        TPositionCode = 0x360d,
        TPropRMark = 0xd667,
        TRsidTr = 0x7479,
        TSetBrc = 0xd62f,
        TSetBrc10 = 0xd626,
        TSetBrc80 = 0xd620,
        TSetShd = 0x7627,
        TSetShdOdd = 0x7628,
        TSplit = 0x5625,
        TTableBorders = 0xd613,
        TTableBorders80 = 0xd605,
        TTableHeader = 0x3404,
        TTableShd = 0xd660,
        TTableWidth = 0xf614,
        TTextFlow = 0x7629,
        TTlp = 0x740a,
        TUndocumented2 = 0x5664,
        TVertAlign = 0xd62c,
        TVertMerge = 0xd62b,
        TWall = 0x3668,
        TWidthAfter = 0xf618,
        TWidthBefore = 0xf617
    }
}
