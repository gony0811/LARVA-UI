using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.CodeGenerators;
using EPLE.Core.Manager.Model;
using EPLE.Core.Manager;
using EPLE.IO;
using EPLE.App;
using System.Collections.ObjectModel;
using DevExpress.Mvvm.Native;

namespace LARVA_UI.ViewModels
{
    public partial class BoxSelectionViewModel
    {


        [GenerateProperty]
        ObservableCollection<string> boxSelectedItems = new ObservableCollection<string>();
        [GenerateProperty]
        private string name_Stock_111;
        [GenerateProperty]
        private string name_Stock_112;
        [GenerateProperty]
        private string name_Stock_113;
        [GenerateProperty]
        private string name_Stock_114;
        [GenerateProperty]
        private string name_Stock_115;
        [GenerateProperty]
        private string name_Stock_116;
        [GenerateProperty]
        private string name_Stock_121;
        [GenerateProperty]
        private string name_Stock_122;
        [GenerateProperty]
        private string name_Stock_123;
        [GenerateProperty]
        private string name_Stock_124;
        [GenerateProperty]
        private string name_Stock_125;
        [GenerateProperty]
        private string name_Stock_126;
        [GenerateProperty]
        private string name_Stock_131;
        [GenerateProperty]
        private string name_Stock_132;
        [GenerateProperty]
        private string name_Stock_133;
        [GenerateProperty]
        private string name_Stock_134;
        [GenerateProperty]
        private string name_Stock_135;
        [GenerateProperty]
        private string name_Stock_136;
        [GenerateProperty]
        private string name_Stock_141;
        [GenerateProperty]
        private string name_Stock_142;
        [GenerateProperty]
        private string name_Stock_143;
        [GenerateProperty]
        private string name_Stock_144;
        [GenerateProperty]
        private string name_Stock_145;
        [GenerateProperty]
        private string name_Stock_146;
        [GenerateProperty]
        private string name_Stock_151;
        [GenerateProperty]
        private string name_Stock_152;
        [GenerateProperty]
        private string name_Stock_153;
        [GenerateProperty]
        private string name_Stock_154;
        [GenerateProperty]
        private string name_Stock_155;
        [GenerateProperty]
        private string name_Stock_156;
        [GenerateProperty]
        private string name_Stock_211;
        [GenerateProperty]
        private string name_Stock_212;
        [GenerateProperty]
        private string name_Stock_213;
        [GenerateProperty]
        private string name_Stock_214;
        [GenerateProperty]
        private string name_Stock_215;
        [GenerateProperty]
        private string name_Stock_216;
        [GenerateProperty]
        private string name_Stock_221;
        [GenerateProperty]
        private string name_Stock_222;
        [GenerateProperty]
        private string name_Stock_223;
        [GenerateProperty]
        private string name_Stock_224;
        [GenerateProperty]
        private string name_Stock_225;
        [GenerateProperty]
        private string name_Stock_226;
        [GenerateProperty]
        private string name_Stock_231;
        [GenerateProperty]
        private string name_Stock_232;
        [GenerateProperty]
        private string name_Stock_233;
        [GenerateProperty]
        private string name_Stock_234;
        [GenerateProperty]
        private string name_Stock_235;
        [GenerateProperty]
        private string name_Stock_236;
        [GenerateProperty]
        private string name_Stock_241;
        [GenerateProperty]
        private string name_Stock_242;
        [GenerateProperty]
        private string name_Stock_243;
        [GenerateProperty]
        private string name_Stock_244;
        [GenerateProperty]
        private string name_Stock_245;
        [GenerateProperty]
        private string name_Stock_246;
        [GenerateProperty]
        private string name_Stock_251;
        [GenerateProperty]
        private string name_Stock_252;
        [GenerateProperty]
        private string name_Stock_253;
        [GenerateProperty]
        private string name_Stock_254;
        [GenerateProperty]
        private string name_Stock_255;
        [GenerateProperty]
        private string name_Stock_256;

        [GenerateProperty]
        private string name_Stock_311;
        [GenerateProperty]
        private string name_Stock_312;
        [GenerateProperty]
        private string name_Stock_313;
        [GenerateProperty]
        private string name_Stock_314;
        [GenerateProperty]
        private string name_Stock_315;
        [GenerateProperty]
        private string name_Stock_316;
        [GenerateProperty]
        private string name_Stock_321;
        [GenerateProperty]
        private string name_Stock_322;
        [GenerateProperty]
        private string name_Stock_323;
        [GenerateProperty]
        private string name_Stock_324;
        [GenerateProperty]
        private string name_Stock_325;
        [GenerateProperty]
        private string name_Stock_326;
        [GenerateProperty]
        private string name_Stock_331;
        [GenerateProperty]
        private string name_Stock_332;
        [GenerateProperty]
        private string name_Stock_333;
        [GenerateProperty]
        private string name_Stock_334;
        [GenerateProperty]
        private string name_Stock_335;
        [GenerateProperty]
        private string name_Stock_336;
        [GenerateProperty]
        private string name_Stock_341;
        [GenerateProperty]
        private string name_Stock_342;
        [GenerateProperty]
        private string name_Stock_343;
        [GenerateProperty]
        private string name_Stock_344;
        [GenerateProperty]
        private string name_Stock_345;
        [GenerateProperty]
        private string name_Stock_346;
        [GenerateProperty]
        private string name_Stock_351;
        [GenerateProperty]
        private string name_Stock_352;
        [GenerateProperty]
        private string name_Stock_353;
        [GenerateProperty]
        private string name_Stock_354;
        [GenerateProperty]
        private string name_Stock_355;
        [GenerateProperty]
        private string name_Stock_356;

        [GenerateProperty]
        private string name_Stock_411;
        [GenerateProperty]
        private string name_Stock_412;
        [GenerateProperty]
        private string name_Stock_413;
        [GenerateProperty]
        private string name_Stock_414;
        [GenerateProperty]
        private string name_Stock_415;
        [GenerateProperty]
        private string name_Stock_416;
        [GenerateProperty]
        private string name_Stock_421;
        [GenerateProperty]
        private string name_Stock_422;
        [GenerateProperty]
        private string name_Stock_423;
        [GenerateProperty]
        private string name_Stock_424;
        [GenerateProperty]
        private string name_Stock_425;
        [GenerateProperty]
        private string name_Stock_426;
        [GenerateProperty]
        private string name_Stock_431;
        [GenerateProperty]
        private string name_Stock_432;
        [GenerateProperty]
        private string name_Stock_433;
        [GenerateProperty]
        private string name_Stock_434;
        [GenerateProperty]
        private string name_Stock_435;
        [GenerateProperty]
        private string name_Stock_436;
        [GenerateProperty]
        private string name_Stock_441;
        [GenerateProperty]
        private string name_Stock_442;
        [GenerateProperty]
        private string name_Stock_443;
        [GenerateProperty]
        private string name_Stock_444;
        [GenerateProperty]
        private string name_Stock_445;
        [GenerateProperty]
        private string name_Stock_446;
        [GenerateProperty]
        private string name_Stock_451;
        [GenerateProperty]
        private string name_Stock_452;
        [GenerateProperty]
        private string name_Stock_453;
        [GenerateProperty]
        private string name_Stock_454;
        [GenerateProperty]
        private string name_Stock_455;
        [GenerateProperty]
        private string name_Stock_456;

        [GenerateProperty]
        private string name_Stock_511;
        [GenerateProperty]
        private string name_Stock_512;
        [GenerateProperty]
        private string name_Stock_513;
        [GenerateProperty]
        private string name_Stock_514;
        [GenerateProperty]
        private string name_Stock_515;
        [GenerateProperty]
        private string name_Stock_516;
        [GenerateProperty]
        private string name_Stock_521;
        [GenerateProperty]
        private string name_Stock_522;
        [GenerateProperty]
        private string name_Stock_523;
        [GenerateProperty]
        private string name_Stock_524;
        [GenerateProperty]
        private string name_Stock_525;
        [GenerateProperty]
        private string name_Stock_526;
        [GenerateProperty]
        private string name_Stock_531;
        [GenerateProperty]
        private string name_Stock_532;
        [GenerateProperty]
        private string name_Stock_533;
        [GenerateProperty]
        private string name_Stock_534;
        [GenerateProperty]
        private string name_Stock_535;
        [GenerateProperty]
        private string name_Stock_536;
        [GenerateProperty]
        private string name_Stock_541;
        [GenerateProperty]
        private string name_Stock_542;
        [GenerateProperty]
        private string name_Stock_543;
        [GenerateProperty]
        private string name_Stock_544;
        [GenerateProperty]
        private string name_Stock_545;
        [GenerateProperty]
        private string name_Stock_546;
        [GenerateProperty]
        private string name_Stock_551;
        [GenerateProperty]
        private string name_Stock_552;
        [GenerateProperty]
        private string name_Stock_553;
        [GenerateProperty]
        private string name_Stock_554;
        [GenerateProperty]
        private string name_Stock_555;
        [GenerateProperty]
        private string name_Stock_556;

        [GenerateProperty]
        private string name_Stock_611;
        [GenerateProperty]
        private string name_Stock_612;
        [GenerateProperty]
        private string name_Stock_613;
        [GenerateProperty]
        private string name_Stock_614;
        [GenerateProperty]
        private string name_Stock_615;
        [GenerateProperty]
        private string name_Stock_616;
        [GenerateProperty]
        private string name_Stock_621;
        [GenerateProperty]
        private string name_Stock_622;
        [GenerateProperty]
        private string name_Stock_623;
        [GenerateProperty]
        private string name_Stock_624;
        [GenerateProperty]
        private string name_Stock_625;
        [GenerateProperty]
        private string name_Stock_626;
        [GenerateProperty]
        private string name_Stock_631;
        [GenerateProperty]
        private string name_Stock_632;
        [GenerateProperty]
        private string name_Stock_633;
        [GenerateProperty]
        private string name_Stock_634;
        [GenerateProperty]
        private string name_Stock_635;
        [GenerateProperty]
        private string name_Stock_636;
        [GenerateProperty]
        private string name_Stock_641;
        [GenerateProperty]
        private string name_Stock_642;
        [GenerateProperty]
        private string name_Stock_643;
        [GenerateProperty]
        private string name_Stock_644;
        [GenerateProperty]
        private string name_Stock_645;
        [GenerateProperty]
        private string name_Stock_646;
        [GenerateProperty]
        private string name_Stock_651;
        [GenerateProperty]
        private string name_Stock_652;
        [GenerateProperty]
        private string name_Stock_653;
        [GenerateProperty]
        private string name_Stock_654;
        [GenerateProperty]
        private string name_Stock_655;
        [GenerateProperty]
        private string name_Stock_656;

        [GenerateProperty]
        private string name_Stock_711;
        [GenerateProperty]
        private string name_Stock_712;
        [GenerateProperty]
        private string name_Stock_713;
        [GenerateProperty]
        private string name_Stock_714;
        [GenerateProperty]
        private string name_Stock_715;
        [GenerateProperty]
        private string name_Stock_716;
        [GenerateProperty]
        private string name_Stock_721;
        [GenerateProperty]
        private string name_Stock_722;
        [GenerateProperty]
        private string name_Stock_723;
        [GenerateProperty]
        private string name_Stock_724;
        [GenerateProperty]
        private string name_Stock_725;
        [GenerateProperty]
        private string name_Stock_726;
        [GenerateProperty]
        private string name_Stock_731;
        [GenerateProperty]
        private string name_Stock_732;
        [GenerateProperty]
        private string name_Stock_733;
        [GenerateProperty]
        private string name_Stock_734;
        [GenerateProperty]
        private string name_Stock_735;
        [GenerateProperty]
        private string name_Stock_736;
        [GenerateProperty]
        private string name_Stock_741;
        [GenerateProperty]
        private string name_Stock_742;
        [GenerateProperty]
        private string name_Stock_743;
        [GenerateProperty]
        private string name_Stock_744;
        [GenerateProperty]
        private string name_Stock_745;
        [GenerateProperty]
        private string name_Stock_746;
        [GenerateProperty]
        private string name_Stock_751;
        [GenerateProperty]
        private string name_Stock_752;
        [GenerateProperty]
        private string name_Stock_753;
        [GenerateProperty]
        private string name_Stock_754;
        [GenerateProperty]
        private string name_Stock_755;
        [GenerateProperty]
        private string name_Stock_756;

        [GenerateProperty]
        private string name_Stock_811;
        [GenerateProperty]
        private string name_Stock_812;
        [GenerateProperty]
        private string name_Stock_813;
        [GenerateProperty]
        private string name_Stock_814;
        [GenerateProperty]
        private string name_Stock_815;
        [GenerateProperty]
        private string name_Stock_816;
        [GenerateProperty]
        private string name_Stock_821;
        [GenerateProperty]
        private string name_Stock_822;
        [GenerateProperty]
        private string name_Stock_823;
        [GenerateProperty]
        private string name_Stock_824;
        [GenerateProperty]
        private string name_Stock_825;
        [GenerateProperty]
        private string name_Stock_826;
        [GenerateProperty]
        private string name_Stock_831;
        [GenerateProperty]
        private string name_Stock_832;
        [GenerateProperty]
        private string name_Stock_833;
        [GenerateProperty]
        private string name_Stock_834;
        [GenerateProperty]
        private string name_Stock_835;
        [GenerateProperty]
        private string name_Stock_836;
        [GenerateProperty]
        private string name_Stock_841;
        [GenerateProperty]
        private string name_Stock_842;
        [GenerateProperty]
        private string name_Stock_843;
        [GenerateProperty]
        private string name_Stock_844;
        [GenerateProperty]
        private string name_Stock_845;
        [GenerateProperty]
        private string name_Stock_846;
        [GenerateProperty]
        private string name_Stock_851;
        [GenerateProperty]
        private string name_Stock_852;
        [GenerateProperty]
        private string name_Stock_853;
        [GenerateProperty]
        private string name_Stock_854;
        [GenerateProperty]
        private string name_Stock_855;
        [GenerateProperty]
        private string name_Stock_856;

        [GenerateProperty]
        private bool isEnabled_111;
        [GenerateProperty]
        private bool isEnabled_112;
        [GenerateProperty]
        private bool isEnabled_113;
        [GenerateProperty]
        private bool isEnabled_114;
        [GenerateProperty]
        private bool isEnabled_115;
        [GenerateProperty]
        private bool isEnabled_116;
        [GenerateProperty]
        private bool isEnabled_121;
        [GenerateProperty]
        private bool isEnabled_122;
        [GenerateProperty]
        private bool isEnabled_123;
        [GenerateProperty]
        private bool isEnabled_124;
        [GenerateProperty]
        private bool isEnabled_125;
        [GenerateProperty]
        private bool isEnabled_126;
        [GenerateProperty]
        private bool isEnabled_131;
        [GenerateProperty]
        private bool isEnabled_132;
        [GenerateProperty]
        private bool isEnabled_133;
        [GenerateProperty]
        private bool isEnabled_134;
        [GenerateProperty]
        private bool isEnabled_135;
        [GenerateProperty]
        private bool isEnabled_136;
        [GenerateProperty]
        private bool isEnabled_141;
        [GenerateProperty]
        private bool isEnabled_142;
        [GenerateProperty]
        private bool isEnabled_143;
        [GenerateProperty]
        private bool isEnabled_144;
        [GenerateProperty]
        private bool isEnabled_145;
        [GenerateProperty]
        private bool isEnabled_146;
        [GenerateProperty]
        private bool isEnabled_151;
        [GenerateProperty]
        private bool isEnabled_152;
        [GenerateProperty]
        private bool isEnabled_153;
        [GenerateProperty]
        private bool isEnabled_154;
        [GenerateProperty]
        private bool isEnabled_155;
        [GenerateProperty]
        private bool isEnabled_156;
        [GenerateProperty]
        private bool isEnabled_211;
        [GenerateProperty]
        private bool isEnabled_212;
        [GenerateProperty]
        private bool isEnabled_213;
        [GenerateProperty]
        private bool isEnabled_214;
        [GenerateProperty]
        private bool isEnabled_215;
        [GenerateProperty]
        private bool isEnabled_216;
        [GenerateProperty]
        private bool isEnabled_221;
        [GenerateProperty]
        private bool isEnabled_222;
        [GenerateProperty]
        private bool isEnabled_223;
        [GenerateProperty]
        private bool isEnabled_224;
        [GenerateProperty]
        private bool isEnabled_225;
        [GenerateProperty]
        private bool isEnabled_226;
        [GenerateProperty]
        private bool isEnabled_231;
        [GenerateProperty]
        private bool isEnabled_232;
        [GenerateProperty]
        private bool isEnabled_233;
        [GenerateProperty]
        private bool isEnabled_234;
        [GenerateProperty]
        private bool isEnabled_235;
        [GenerateProperty]
        private bool isEnabled_236;
        [GenerateProperty]
        private bool isEnabled_241;
        [GenerateProperty]
        private bool isEnabled_242;
        [GenerateProperty]
        private bool isEnabled_243;
        [GenerateProperty]
        private bool isEnabled_244;
        [GenerateProperty]
        private bool isEnabled_245;
        [GenerateProperty]
        private bool isEnabled_246;
        [GenerateProperty]
        private bool isEnabled_251;
        [GenerateProperty]
        private bool isEnabled_252;
        [GenerateProperty]
        private bool isEnabled_253;
        [GenerateProperty]
        private bool isEnabled_254;
        [GenerateProperty]
        private bool isEnabled_255;
        [GenerateProperty]
        private bool isEnabled_256;

        [GenerateProperty]
        private bool isEnabled_311;
        [GenerateProperty]
        private bool isEnabled_312;
        [GenerateProperty]
        private bool isEnabled_313;
        [GenerateProperty]
        private bool isEnabled_314;
        [GenerateProperty]
        private bool isEnabled_315;
        [GenerateProperty]
        private bool isEnabled_316;
        [GenerateProperty]
        private bool isEnabled_321;
        [GenerateProperty]
        private bool isEnabled_322;
        [GenerateProperty]
        private bool isEnabled_323;
        [GenerateProperty]
        private bool isEnabled_324;
        [GenerateProperty]
        private bool isEnabled_325;
        [GenerateProperty]
        private bool isEnabled_326;
        [GenerateProperty]
        private bool isEnabled_331;
        [GenerateProperty]
        private bool isEnabled_332;
        [GenerateProperty]
        private bool isEnabled_333;
        [GenerateProperty]
        private bool isEnabled_334;
        [GenerateProperty]
        private bool isEnabled_335;
        [GenerateProperty]
        private bool isEnabled_336;
        [GenerateProperty]
        private bool isEnabled_341;
        [GenerateProperty]
        private bool isEnabled_342;
        [GenerateProperty]
        private bool isEnabled_343;
        [GenerateProperty]
        private bool isEnabled_344;
        [GenerateProperty]
        private bool isEnabled_345;
        [GenerateProperty]
        private bool isEnabled_346;
        [GenerateProperty]
        private bool isEnabled_351;
        [GenerateProperty]
        private bool isEnabled_352;
        [GenerateProperty]
        private bool isEnabled_353;
        [GenerateProperty]
        private bool isEnabled_354;
        [GenerateProperty]
        private bool isEnabled_355;
        [GenerateProperty]
        private bool isEnabled_356;

        [GenerateProperty]
        private bool isEnabled_411;
        [GenerateProperty]
        private bool isEnabled_412;
        [GenerateProperty]
        private bool isEnabled_413;
        [GenerateProperty]
        private bool isEnabled_414;
        [GenerateProperty]
        private bool isEnabled_415;
        [GenerateProperty]
        private bool isEnabled_416;
        [GenerateProperty]
        private bool isEnabled_421;
        [GenerateProperty]
        private bool isEnabled_422;
        [GenerateProperty]
        private bool isEnabled_423;
        [GenerateProperty]
        private bool isEnabled_424;
        [GenerateProperty]
        private bool isEnabled_425;
        [GenerateProperty]
        private bool isEnabled_426;
        [GenerateProperty]
        private bool isEnabled_431;
        [GenerateProperty]
        private bool isEnabled_432;
        [GenerateProperty]
        private bool isEnabled_433;
        [GenerateProperty]
        private bool isEnabled_434;
        [GenerateProperty]
        private bool isEnabled_435;
        [GenerateProperty]
        private bool isEnabled_436;
        [GenerateProperty]
        private bool isEnabled_441;
        [GenerateProperty]
        private bool isEnabled_442;
        [GenerateProperty]
        private bool isEnabled_443;
        [GenerateProperty]
        private bool isEnabled_444;
        [GenerateProperty]
        private bool isEnabled_445;
        [GenerateProperty]
        private bool isEnabled_446;
        [GenerateProperty]
        private bool isEnabled_451;
        [GenerateProperty]
        private bool isEnabled_452;
        [GenerateProperty]
        private bool isEnabled_453;
        [GenerateProperty]
        private bool isEnabled_454;
        [GenerateProperty]
        private bool isEnabled_455;
        [GenerateProperty]
        private bool isEnabled_456;

        [GenerateProperty]
        private bool isEnabled_511;
        [GenerateProperty]
        private bool isEnabled_512;
        [GenerateProperty]
        private bool isEnabled_513;
        [GenerateProperty]
        private bool isEnabled_514;
        [GenerateProperty]
        private bool isEnabled_515;
        [GenerateProperty]
        private bool isEnabled_516;
        [GenerateProperty]
        private bool isEnabled_521;
        [GenerateProperty]
        private bool isEnabled_522;
        [GenerateProperty]
        private bool isEnabled_523;
        [GenerateProperty]
        private bool isEnabled_524;
        [GenerateProperty]
        private bool isEnabled_525;
        [GenerateProperty]
        private bool isEnabled_526;
        [GenerateProperty]
        private bool isEnabled_531;
        [GenerateProperty]
        private bool isEnabled_532;
        [GenerateProperty]
        private bool isEnabled_533;
        [GenerateProperty]
        private bool isEnabled_534;
        [GenerateProperty]
        private bool isEnabled_535;
        [GenerateProperty]
        private bool isEnabled_536;
        [GenerateProperty]
        private bool isEnabled_541;
        [GenerateProperty]
        private bool isEnabled_542;
        [GenerateProperty]
        private bool isEnabled_543;
        [GenerateProperty]
        private bool isEnabled_544;
        [GenerateProperty]
        private bool isEnabled_545;
        [GenerateProperty]
        private bool isEnabled_546;
        [GenerateProperty]
        private bool isEnabled_551;
        [GenerateProperty]
        private bool isEnabled_552;
        [GenerateProperty]
        private bool isEnabled_553;
        [GenerateProperty]
        private bool isEnabled_554;
        [GenerateProperty]
        private bool isEnabled_555;
        [GenerateProperty]
        private bool isEnabled_556;

        [GenerateProperty]
        private bool isEnabled_611;
        [GenerateProperty]
        private bool isEnabled_612;
        [GenerateProperty]
        private bool isEnabled_613;
        [GenerateProperty]
        private bool isEnabled_614;
        [GenerateProperty]
        private bool isEnabled_615;
        [GenerateProperty]
        private bool isEnabled_616;
        [GenerateProperty]
        private bool isEnabled_621;
        [GenerateProperty]
        private bool isEnabled_622;
        [GenerateProperty]
        private bool isEnabled_623;
        [GenerateProperty]
        private bool isEnabled_624;
        [GenerateProperty]
        private bool isEnabled_625;
        [GenerateProperty]
        private bool isEnabled_626;
        [GenerateProperty]
        private bool isEnabled_631;
        [GenerateProperty]
        private bool isEnabled_632;
        [GenerateProperty]
        private bool isEnabled_633;
        [GenerateProperty]
        private bool isEnabled_634;
        [GenerateProperty]
        private bool isEnabled_635;
        [GenerateProperty]
        private bool isEnabled_636;
        [GenerateProperty]
        private bool isEnabled_641;
        [GenerateProperty]
        private bool isEnabled_642;
        [GenerateProperty]
        private bool isEnabled_643;
        [GenerateProperty]
        private bool isEnabled_644;
        [GenerateProperty]
        private bool isEnabled_645;
        [GenerateProperty]
        private bool isEnabled_646;
        [GenerateProperty]
        private bool isEnabled_651;
        [GenerateProperty]
        private bool isEnabled_652;
        [GenerateProperty]
        private bool isEnabled_653;
        [GenerateProperty]
        private bool isEnabled_654;
        [GenerateProperty]
        private bool isEnabled_655;
        [GenerateProperty]
        private bool isEnabled_656;

        [GenerateProperty]
        private bool isEnabled_711;
        [GenerateProperty]
        private bool isEnabled_712;
        [GenerateProperty]
        private bool isEnabled_713;
        [GenerateProperty]
        private bool isEnabled_714;
        [GenerateProperty]
        private bool isEnabled_715;
        [GenerateProperty]
        private bool isEnabled_716;
        [GenerateProperty]
        private bool isEnabled_721;
        [GenerateProperty]
        private bool isEnabled_722;
        [GenerateProperty]
        private bool isEnabled_723;
        [GenerateProperty]
        private bool isEnabled_724;
        [GenerateProperty]
        private bool isEnabled_725;
        [GenerateProperty]
        private bool isEnabled_726;
        [GenerateProperty]
        private bool isEnabled_731;
        [GenerateProperty]
        private bool isEnabled_732;
        [GenerateProperty]
        private bool isEnabled_733;
        [GenerateProperty]
        private bool isEnabled_734;
        [GenerateProperty]
        private bool isEnabled_735;
        [GenerateProperty]
        private bool isEnabled_736;
        [GenerateProperty]
        private bool isEnabled_741;
        [GenerateProperty]
        private bool isEnabled_742;
        [GenerateProperty]
        private bool isEnabled_743;
        [GenerateProperty]
        private bool isEnabled_744;
        [GenerateProperty]
        private bool isEnabled_745;
        [GenerateProperty]
        private bool isEnabled_746;
        [GenerateProperty]
        private bool isEnabled_751;
        [GenerateProperty]
        private bool isEnabled_752;
        [GenerateProperty]
        private bool isEnabled_753;
        [GenerateProperty]
        private bool isEnabled_754;
        [GenerateProperty]
        private bool isEnabled_755;
        [GenerateProperty]
        private bool isEnabled_756;

        [GenerateProperty]
        private bool isEnabled_811;
        [GenerateProperty]
        private bool isEnabled_812;
        [GenerateProperty]
        private bool isEnabled_813;
        [GenerateProperty]
        private bool isEnabled_814;
        [GenerateProperty]
        private bool isEnabled_815;
        [GenerateProperty]
        private bool isEnabled_816;
        [GenerateProperty]
        private bool isEnabled_821;
        [GenerateProperty]
        private bool isEnabled_822;
        [GenerateProperty]
        private bool isEnabled_823;
        [GenerateProperty]
        private bool isEnabled_824;
        [GenerateProperty]
        private bool isEnabled_825;
        [GenerateProperty]
        private bool isEnabled_826;
        [GenerateProperty]
        private bool isEnabled_831;
        [GenerateProperty]
        private bool isEnabled_832;
        [GenerateProperty]
        private bool isEnabled_833;
        [GenerateProperty]
        private bool isEnabled_834;
        [GenerateProperty]
        private bool isEnabled_835;
        [GenerateProperty]
        private bool isEnabled_836;
        [GenerateProperty]
        private bool isEnabled_841;
        [GenerateProperty]
        private bool isEnabled_842;
        [GenerateProperty]
        private bool isEnabled_843;
        [GenerateProperty]
        private bool isEnabled_844;
        [GenerateProperty]
        private bool isEnabled_845;
        [GenerateProperty]
        private bool isEnabled_846;
        [GenerateProperty]
        private bool isEnabled_851;
        [GenerateProperty]
        private bool isEnabled_852;
        [GenerateProperty]
        private bool isEnabled_853;
        [GenerateProperty]
        private bool isEnabled_854;
        [GenerateProperty]
        private bool isEnabled_855;
        [GenerateProperty]
        private bool isEnabled_856;

        [GenerateProperty]
        private string name_btn_larva_level_0;
        [GenerateProperty]
        private string name_btn_larva_level_1;
        [GenerateProperty]
        private string name_btn_larva_level_2;
        [GenerateProperty]
        private string name_btn_larva_level_3;
        [GenerateProperty]
        private string name_btn_larva_level_4;
        [GenerateProperty]
        private string name_btn_larva_level_5;
        [GenerateProperty]
        private string name_btn_larva_level_6;
        [GenerateProperty]
        private string name_btn_larva_level_7;
        [GenerateProperty]
        private bool isEnabled_btn_larva_level_0;
        [GenerateProperty]
        private bool isEnabled_btn_larva_level_1;
        [GenerateProperty]
        private bool isEnabled_btn_larva_level_2;
        [GenerateProperty]
        private bool isEnabled_btn_larva_level_3;
        [GenerateProperty]
        private bool isEnabled_btn_larva_level_4;
        [GenerateProperty]
        private bool isEnabled_btn_larva_level_5;
        [GenerateProperty]
        private bool isEnabled_btn_larva_level_6;
        [GenerateProperty]
        private bool isEnabled_btn_larva_level_7;

        public BoxSelectionViewModel()
        {
            InitializeButtonStatus();
            InitializeButtonEnable();

            DataManager.Instance.DataAccess.DataChangedEvent += DataChanged;
        }

        private void DataChanged(object sender, DataChangedEventHandlerArgs e)
        {
            switch(e.Data.Name)
            {
                case IoNameHelper.iStock_nBox_111F:
                    IsEnabled_111 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_111R:
                    //IsEnabled_112 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_112F:
                    IsEnabled_113 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_112R:
                    //IsEnabled_114 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_113F:
                    IsEnabled_115 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_113R:
                   //IsEnabled_116 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_121F:
                    IsEnabled_121 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_121R:
                    //IsEnabled_122 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_122F:
                    IsEnabled_123 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_122R:
                    //IsEnabled_124 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_123F:
                    IsEnabled_125 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_123R:
                    //IsEnabled_126 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_131F:
                    IsEnabled_131 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_131R:
                    //IsEnabled_132 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_132F:
                    IsEnabled_133 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_132R:
                    //IsEnabled_134 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_133F:
                    IsEnabled_135 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_133R:
                    //IsEnabled_136 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_141F:
                    IsEnabled_141 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_141R:
                    //IsEnabled_142 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_142F:
                    IsEnabled_143 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_142R:
                    //IsEnabled_144 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_143F:
                    IsEnabled_145 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_143R:
                    //IsEnabled_146 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_151F:
                    IsEnabled_151 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_151R:
                    //IsEnabled_152 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_152F:
                    IsEnabled_153 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_152R:
                    //IsEnabled_154 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_153F:
                    IsEnabled_155 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_153R:
                    //IsEnabled_156 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_211F:
                    IsEnabled_211 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_211R:
                    //IsEnabled_212 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_212F:
                    IsEnabled_213 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_212R:
                    //IsEnabled_214 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_213F:
                    IsEnabled_215 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_213R:
                    //IsEnabled_216 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_221F:
                    IsEnabled_221 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_221R:
                    //IsEnabled_222 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_222F:
                    IsEnabled_223 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_222R:
                    //IsEnabled_224 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_223F:
                    IsEnabled_225 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_223R:
                    //IsEnabled_226 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_231F:
                    IsEnabled_231 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_231R:
                    //IsEnabled_232 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_232F:
                    IsEnabled_233 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_232R:
                    //IsEnabled_234 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_233F:
                    IsEnabled_235 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_233R:
                    //IsEnabled_236 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_241F:
                    IsEnabled_241 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_241R:
                    //IsEnabled_242 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_242F:
                    IsEnabled_243 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_242R:
                    //IsEnabled_244 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_243F:
                    IsEnabled_245 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_243R:
                    //IsEnabled_246 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_251F:
                    IsEnabled_251 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_251R:
                    //IsEnabled_252 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_252F:
                    IsEnabled_253 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_252R:
                    //IsEnabled_254 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_253F:
                    IsEnabled_255 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_253R:
                    //IsEnabled_256 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_311F:
                    IsEnabled_311 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_311R:
                    //IsEnabled_312 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_312F:
                    IsEnabled_313 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_312R:
                    //IsEnabled_314 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_313F:
                    IsEnabled_315 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_313R:
                    //IsEnabled_316 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_321F:
                    IsEnabled_321 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_321R:
                    //IsEnabled_322 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_322F:
                    IsEnabled_323 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_322R:
                    //IsEnabled_324 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_323F:
                    IsEnabled_325 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_323R:
                    //IsEnabled_326 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_331F:
                    IsEnabled_331 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_331R:
                    //IsEnabled_332 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_332F:
                    IsEnabled_333 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_332R:
                    //IsEnabled_334 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_333F:
                    IsEnabled_335 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_333R:
                    //IsEnabled_336 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_341F:
                    IsEnabled_341 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_341R:
                    //IsEnabled_342 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_342F:
                    IsEnabled_343 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_342R:
                    //IsEnabled_344 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_343F:
                    IsEnabled_345 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_343R:
                    //IsEnabled_346 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_351F:
                    IsEnabled_351 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_351R:
                    //IsEnabled_352 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_352F:
                    IsEnabled_353 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_352R:
                    //IsEnabled_354 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_353F:
                    IsEnabled_355 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_353R:
                    //IsEnabled_356 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_411F:
                    IsEnabled_411 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_411R:
                    //IsEnabled_412 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_412F:
                    IsEnabled_413 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_412R:
                    //IsEnabled_414 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_413F:
                    IsEnabled_415 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_413R:
                    //IsEnabled_416 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_421F:
                    IsEnabled_421 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_421R:
                    //IsEnabled_422 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_422F:
                    IsEnabled_423 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_422R:
                    //IsEnabled_424 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_423F:
                    IsEnabled_425 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_423R:
                    //IsEnabled_426 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_431F:
                    IsEnabled_431 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_431R:
                    //IsEnabled_432 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_432F:
                    IsEnabled_433 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_432R:
                    //IsEnabled_434 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_433F:
                    IsEnabled_435 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_433R:
                    //IsEnabled_436 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_441F:
                    IsEnabled_441 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_441R:
                    //IsEnabled_442 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_442F:
                    IsEnabled_443 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_442R:
                    //IsEnabled_444 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_443F:
                    IsEnabled_445 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_443R:
                    //IsEnabled_446 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_451F:
                    IsEnabled_451 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_451R:
                    //IsEnabled_452 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_452F:
                    IsEnabled_453 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_452R:
                    //IsEnabled_454 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_453F:
                    IsEnabled_455 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_453R:
                    //IsEnabled_456 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_511F:
                    IsEnabled_511 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_511R:
                    //IsEnabled_512 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_512F:
                    IsEnabled_513 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_512R:
                    //IsEnabled_514 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_513F:
                    IsEnabled_515 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_513R:
                    //IsEnabled_516 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_521F:
                    IsEnabled_521 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_521R:
                    //IsEnabled_522 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_522F:
                    IsEnabled_523 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_522R:
                    //IsEnabled_524 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_523F:
                    IsEnabled_525 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_523R:
                    //IsEnabled_526 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_531F:
                    IsEnabled_531 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_531R:
                    //IsEnabled_532 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_532F:
                    IsEnabled_533 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_532R:
                    //IsEnabled_534 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_533F:
                    IsEnabled_535 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_533R:
                    //IsEnabled_536 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_541F:
                    IsEnabled_541 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_541R:
                    //IsEnabled_542 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_542F:
                    IsEnabled_543 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_542R:
                    //IsEnabled_544 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_543F:
                    IsEnabled_545 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_543R:
                    //IsEnabled_546 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_551F:
                    IsEnabled_551 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_551R:
                    //IsEnabled_552 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_552F:
                    IsEnabled_553 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_552R:
                    //IsEnabled_554 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_553F:
                    IsEnabled_555 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_553R:
                   // IsEnabled_556 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_611F:
                    IsEnabled_611 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_611R:
                    //IsEnabled_612 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_612F:
                    IsEnabled_613 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_612R:
                    //IsEnabled_614 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_613F:
                    IsEnabled_615 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_613R:
                    //IsEnabled_616 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_621F:
                    IsEnabled_621 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_621R:
                    //IsEnabled_622 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_622F:
                    IsEnabled_623 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_622R:
                    //IsEnabled_624 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_623F:
                    IsEnabled_625 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_623R:
                    //IsEnabled_626 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_631F:
                    IsEnabled_631 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_631R:
                    //IsEnabled_632 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_632F:
                    IsEnabled_633 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_632R:
                    //IsEnabled_634 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_633F:
                    IsEnabled_635 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_633R:
                    //IsEnabled_636 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_641F:
                    IsEnabled_641 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_641R:
                    //IsEnabled_642 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_642F:
                    IsEnabled_643 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_642R:
                    //IsEnabled_644 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_643F:
                    IsEnabled_645 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_643R:
                    //IsEnabled_646 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_651F:
                    IsEnabled_651 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_651R:
                    //IsEnabled_652 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_652F:
                    IsEnabled_653 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_652R:
                    //IsEnabled_654 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_653F:
                    IsEnabled_655 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_653R:
                    //IsEnabled_656 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_711F:
                    IsEnabled_711 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_711R:
                    //IsEnabled_712 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_712F:
                    IsEnabled_713 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_712R:
                    //IsEnabled_714 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_713F:
                    IsEnabled_715 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_713R:
                    //IsEnabled_716 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_721F:
                    IsEnabled_721 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_721R:
                    //IsEnabled_722 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_722F:
                    IsEnabled_723 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_722R:
                    //IsEnabled_724 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_723F:
                    IsEnabled_725 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_723R:
                    //IsEnabled_726 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_731F:
                    IsEnabled_731 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_731R:
                    //IsEnabled_732 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_732F:
                    IsEnabled_733 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_732R:
                    //IsEnabled_734 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_733F:
                    IsEnabled_735 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_733R:
                   // IsEnabled_736 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_741F:
                    IsEnabled_741 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_741R:
                   // IsEnabled_742 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_742F:
                    IsEnabled_743 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_742R:
                    //IsEnabled_744 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_743F:
                    IsEnabled_745 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_743R:
                    //IsEnabled_746 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_751F:
                    IsEnabled_751 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_751R:
                    //IsEnabled_752 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_752F:
                    IsEnabled_753 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_752R:
                    //IsEnabled_754 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_753F:
                    IsEnabled_755 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_753R:
                    //IsEnabled_756 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_811F:
                    IsEnabled_811 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_811R:
                    //IsEnabled_812 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_812F:
                    IsEnabled_813 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_812R:
                    //IsEnabled_814 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_813F:
                    IsEnabled_815 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_813R:
                    //IsEnabled_816 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_821F:
                    IsEnabled_821 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_821R:
                    //IsEnabled_822 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_822F:
                    IsEnabled_823 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_822R:
                    //IsEnabled_824 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_823F:
                    IsEnabled_825 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_823R:
                    //IsEnabled_826 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_831F:
                    IsEnabled_831 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_831R:
                    //IsEnabled_832 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_832F:
                    IsEnabled_833 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_832R:
                    //IsEnabled_834 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_833F:
                    IsEnabled_835 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_833R:
                    //IsEnabled_836 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_841F:
                    IsEnabled_841 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_841R:
                    //IsEnabled_842 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_842F:
                    IsEnabled_843 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_842R:
                    //IsEnabled_844 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_843F:
                    IsEnabled_845 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_843R:
                    //IsEnabled_846 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_851F:
                    IsEnabled_851 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_851R:
                    //IsEnabled_852 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_852F:
                    IsEnabled_853 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_852R:
                    //IsEnabled_854 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_853F:
                    IsEnabled_855 = GetStockBoxIsExist(e.Data.Name);
                    break;
                case IoNameHelper.iStock_nBox_853R:
                    //IsEnabled_856 = GetStockBoxIsExist(e.Data.Name);
                    break;
            }
           




            


            IsEnabled_211 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_211F);
            IsEnabled_212 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_211R);
            IsEnabled_213 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_212F);
            IsEnabled_214 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_212R);
            IsEnabled_215 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_213F);
            IsEnabled_216 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_213R);
            IsEnabled_221 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_221F);
            IsEnabled_222 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_221R);
            IsEnabled_223 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_222F);
            IsEnabled_224 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_222R);
            IsEnabled_225 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_223F);
            IsEnabled_226 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_223R);
            IsEnabled_231 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_231F);
            IsEnabled_232 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_231R);
            IsEnabled_233 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_232F);
            IsEnabled_234 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_232R);
            IsEnabled_235 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_233F);
            IsEnabled_236 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_233R);
            IsEnabled_241 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_241F);
            IsEnabled_242 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_241R);
            IsEnabled_243 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_242F);
            IsEnabled_244 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_242R);
            IsEnabled_245 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_243F);
            IsEnabled_246 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_243R);
            IsEnabled_251 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_251F);
            IsEnabled_252 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_251R);
            IsEnabled_253 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_252F);
            IsEnabled_254 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_252R);
            IsEnabled_255 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_253F);
            IsEnabled_256 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_253R);

            IsEnabled_311 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_311F);
            IsEnabled_312 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_311R);
            IsEnabled_313 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_312F);
            IsEnabled_314 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_312R);
            IsEnabled_315 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_313F);
            IsEnabled_316 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_313R);
            IsEnabled_321 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_321F);
            IsEnabled_322 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_321R);
            IsEnabled_323 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_322F);
            IsEnabled_324 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_322R);
            IsEnabled_325 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_323F);
            IsEnabled_326 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_323R);
            IsEnabled_331 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_331F);
            IsEnabled_332 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_331R);
            IsEnabled_333 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_332F);
            IsEnabled_334 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_332R);
            IsEnabled_335 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_333F);
            IsEnabled_336 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_333R);
            IsEnabled_341 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_341F);
            IsEnabled_342 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_341R);
            IsEnabled_343 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_342F);
            IsEnabled_344 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_342R);
            IsEnabled_345 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_343F);
            IsEnabled_346 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_343R);
            IsEnabled_351 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_351F);
            IsEnabled_352 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_351R);
            IsEnabled_353 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_352F);
            IsEnabled_354 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_352R);
            IsEnabled_355 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_353F);
            IsEnabled_356 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_353R);


            IsEnabled_411 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_411F);
            IsEnabled_412 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_411R);
            IsEnabled_413 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_412F);
            IsEnabled_414 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_412R);
            IsEnabled_415 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_413F);
            IsEnabled_416 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_413R);
            IsEnabled_421 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_421F);
            IsEnabled_422 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_421R);
            IsEnabled_423 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_422F);
            IsEnabled_424 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_422R);
            IsEnabled_425 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_423F);
            IsEnabled_426 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_423R);
            IsEnabled_431 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_431F);
            IsEnabled_432 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_431R);
            IsEnabled_433 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_432F);
            IsEnabled_434 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_432R);
            IsEnabled_435 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_433F);
            IsEnabled_436 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_433R);
            IsEnabled_441 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_441F);
            IsEnabled_442 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_441R);
            IsEnabled_443 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_442F);
            IsEnabled_444 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_442R);
            IsEnabled_445 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_443F);
            IsEnabled_446 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_443R);
            IsEnabled_451 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_451F);
            IsEnabled_452 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_451R);
            IsEnabled_453 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_452F);
            IsEnabled_454 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_452R);
            IsEnabled_455 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_453F);
            IsEnabled_456 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_453R);


            IsEnabled_511 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_511F);
            IsEnabled_512 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_511R);
            IsEnabled_513 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_512F);
            IsEnabled_514 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_512R);
            IsEnabled_515 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_513F);
            IsEnabled_516 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_513R);
            IsEnabled_521 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_521F);
            IsEnabled_522 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_521R);
            IsEnabled_523 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_522F);
            IsEnabled_524 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_522R);
            IsEnabled_525 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_523F);
            IsEnabled_526 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_523R);
            IsEnabled_531 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_531F);
            IsEnabled_532 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_531R);
            IsEnabled_533 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_532F);
            IsEnabled_534 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_532R);
            IsEnabled_535 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_533F);
            IsEnabled_536 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_533R);
            IsEnabled_541 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_541F);
            IsEnabled_542 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_541R);
            IsEnabled_543 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_542F);
            IsEnabled_544 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_542R);
            IsEnabled_545 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_543F);
            IsEnabled_546 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_543R);
            IsEnabled_551 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_551F);
            IsEnabled_552 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_551R);
            IsEnabled_553 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_552F);
            IsEnabled_554 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_552R);
            IsEnabled_555 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_553F);
            IsEnabled_556 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_553R);


            IsEnabled_611 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_611F);
            IsEnabled_612 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_611R);
            IsEnabled_613 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_612F);
            IsEnabled_614 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_612R);
            IsEnabled_615 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_613F);
            IsEnabled_616 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_613R);
            IsEnabled_621 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_621F);
            IsEnabled_622 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_621R);
            IsEnabled_623 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_622F);
            IsEnabled_624 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_622R);
            IsEnabled_625 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_623F);
            IsEnabled_626 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_623R);
            IsEnabled_631 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_631F);
            IsEnabled_632 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_631R);
            IsEnabled_633 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_632F);
            IsEnabled_634 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_632R);
            IsEnabled_635 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_633F);
            IsEnabled_636 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_633R);
            IsEnabled_641 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_641F);
            IsEnabled_642 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_641R);
            IsEnabled_643 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_642F);
            IsEnabled_644 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_642R);
            IsEnabled_645 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_643F);
            IsEnabled_646 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_643R);
            IsEnabled_651 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_651F);
            IsEnabled_652 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_651R);
            IsEnabled_653 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_652F);
            IsEnabled_654 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_652R);
            IsEnabled_655 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_653F);
            IsEnabled_656 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_653R);

            IsEnabled_711 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_711F);
            IsEnabled_712 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_711R);
            IsEnabled_713 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_712F);
            IsEnabled_714 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_712R);
            IsEnabled_715 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_713F);
            IsEnabled_716 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_713R);
            IsEnabled_721 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_721F);
            IsEnabled_722 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_721R);
            IsEnabled_723 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_722F);
            IsEnabled_724 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_722R);
            IsEnabled_725 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_723F);
            IsEnabled_726 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_723R);
            IsEnabled_731 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_731F);
            IsEnabled_732 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_731R);
            IsEnabled_733 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_732F);
            IsEnabled_734 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_732R);
            IsEnabled_735 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_733F);
            IsEnabled_736 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_733R);
            IsEnabled_741 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_741F);
            IsEnabled_742 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_741R);
            IsEnabled_743 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_742F);
            IsEnabled_744 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_742R);
            IsEnabled_745 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_743F);
            IsEnabled_746 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_743R);
            IsEnabled_751 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_751F);
            IsEnabled_752 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_751R);
            IsEnabled_753 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_752F);
            IsEnabled_754 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_752R);
            IsEnabled_755 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_753F);
            IsEnabled_756 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_753R);


            IsEnabled_811 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_811F);
            IsEnabled_812 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_811R);
            IsEnabled_813 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_812F);
            IsEnabled_814 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_812R);
            IsEnabled_815 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_813F);
            IsEnabled_816 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_813R);
            IsEnabled_821 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_821F);
            IsEnabled_822 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_821R);
            IsEnabled_823 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_822F);
            IsEnabled_824 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_822R);
            IsEnabled_825 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_823F);
            IsEnabled_826 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_823R);
            IsEnabled_831 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_831F);
            IsEnabled_832 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_831R);
            IsEnabled_833 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_832F);
            IsEnabled_834 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_832R);
            IsEnabled_835 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_833F);
            IsEnabled_836 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_833R);
            IsEnabled_841 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_841F);
            IsEnabled_842 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_841R);
            IsEnabled_843 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_842F);
            IsEnabled_844 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_842R);
            IsEnabled_845 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_843F);
            IsEnabled_846 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_843R);
            IsEnabled_851 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_851F);
            IsEnabled_852 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_851R);
            IsEnabled_853 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_852F);
            IsEnabled_854 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_852R);
            IsEnabled_855 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_853F);
            IsEnabled_856 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_853R);
        }

        private string GetStockName(string stockName)
        {
            LOCATION_INFO shelfinfo = LocationManager.Instance.GetLocationList().FindAll((x) => (x.LOCATION_NAME.Equals(stockName))).FirstOrDefault();
            return $"{shelfinfo.LOCATION_NAME}\n{shelfinfo.LEVEL}";
        }

        private bool GetStockBoxIsExist(string ioName)
        {
            bool result = false;
            bool val = DataManager.Instance.GET_BOOL_DATA(ioName, out result);

            return result ? val : false;
        }

        

        void InitializeButtonEnable()
        {
            IsEnabled_111 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_111F);
            IsEnabled_112 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_111R);
            IsEnabled_113 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_112F);
            IsEnabled_114 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_112R);
            IsEnabled_115 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_113F);
            IsEnabled_116 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_113R);
            IsEnabled_121 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_121F);
            IsEnabled_122 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_121R);
            IsEnabled_123 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_122F);
            IsEnabled_124 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_122R);
            IsEnabled_125 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_123F);
            IsEnabled_126 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_123R);
            IsEnabled_131 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_131F);
            IsEnabled_132 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_131R);
            IsEnabled_133 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_132F);
            IsEnabled_134 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_132R);
            IsEnabled_135 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_133F);
            IsEnabled_136 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_133R);
            IsEnabled_141 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_141F);
            IsEnabled_142 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_141R);
            IsEnabled_143 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_142F);
            IsEnabled_144 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_142R);
            IsEnabled_145 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_143F);
            IsEnabled_146 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_143R);
            IsEnabled_151 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_151F);
            IsEnabled_152 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_151R);
            IsEnabled_153 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_152F);
            IsEnabled_154 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_152R);
            IsEnabled_155 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_153F);
            IsEnabled_156 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_153R);

            IsEnabled_211 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_211F);
            IsEnabled_212 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_211R);
            IsEnabled_213 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_212F);
            IsEnabled_214 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_212R);
            IsEnabled_215 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_213F);
            IsEnabled_216 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_213R);
            IsEnabled_221 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_221F);
            IsEnabled_222 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_221R);
            IsEnabled_223 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_222F);
            IsEnabled_224 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_222R);
            IsEnabled_225 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_223F);
            IsEnabled_226 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_223R);
            IsEnabled_231 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_231F);
            IsEnabled_232 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_231R);
            IsEnabled_233 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_232F);
            IsEnabled_234 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_232R);
            IsEnabled_235 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_233F);
            IsEnabled_236 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_233R);
            IsEnabled_241 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_241F);
            IsEnabled_242 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_241R);
            IsEnabled_243 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_242F);
            IsEnabled_244 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_242R);
            IsEnabled_245 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_243F);
            IsEnabled_246 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_243R);
            IsEnabled_251 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_251F);
            IsEnabled_252 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_251R);
            IsEnabled_253 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_252F);
            IsEnabled_254 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_252R);
            IsEnabled_255 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_253F);
            IsEnabled_256 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_253R);

            IsEnabled_311 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_311F);
            IsEnabled_312 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_311R);
            IsEnabled_313 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_312F);
            IsEnabled_314 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_312R);
            IsEnabled_315 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_313F);
            IsEnabled_316 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_313R);
            IsEnabled_321 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_321F);
            IsEnabled_322 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_321R);
            IsEnabled_323 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_322F);
            IsEnabled_324 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_322R);
            IsEnabled_325 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_323F);
            IsEnabled_326 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_323R);
            IsEnabled_331 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_331F);
            IsEnabled_332 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_331R);
            IsEnabled_333 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_332F);
            IsEnabled_334 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_332R);
            IsEnabled_335 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_333F);
            IsEnabled_336 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_333R);
            IsEnabled_341 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_341F);
            IsEnabled_342 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_341R);
            IsEnabled_343 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_342F);
            IsEnabled_344 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_342R);
            IsEnabled_345 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_343F);
            IsEnabled_346 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_343R);
            IsEnabled_351 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_351F);
            IsEnabled_352 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_351R);
            IsEnabled_353 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_352F);
            IsEnabled_354 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_352R);
            IsEnabled_355 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_353F);
            IsEnabled_356 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_353R);


            IsEnabled_411 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_411F);
            IsEnabled_412 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_411R);
            IsEnabled_413 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_412F);
            IsEnabled_414 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_412R);
            IsEnabled_415 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_413F);
            IsEnabled_416 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_413R);
            IsEnabled_421 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_421F);
            IsEnabled_422 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_421R);
            IsEnabled_423 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_422F);
            IsEnabled_424 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_422R);
            IsEnabled_425 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_423F);
            IsEnabled_426 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_423R);
            IsEnabled_431 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_431F);
            IsEnabled_432 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_431R);
            IsEnabled_433 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_432F);
            IsEnabled_434 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_432R);
            IsEnabled_435 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_433F);
            IsEnabled_436 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_433R);
            IsEnabled_441 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_441F);
            IsEnabled_442 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_441R);
            IsEnabled_443 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_442F);
            IsEnabled_444 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_442R);
            IsEnabled_445 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_443F);
            IsEnabled_446 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_443R);
            IsEnabled_451 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_451F);
            IsEnabled_452 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_451R);
            IsEnabled_453 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_452F);
            IsEnabled_454 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_452R);
            IsEnabled_455 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_453F);
            IsEnabled_456 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_453R);


            IsEnabled_511 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_511F);
            IsEnabled_512 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_511R);
            IsEnabled_513 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_512F);
            IsEnabled_514 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_512R);
            IsEnabled_515 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_513F);
            IsEnabled_516 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_513R);
            IsEnabled_521 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_521F);
            IsEnabled_522 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_521R);
            IsEnabled_523 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_522F);
            IsEnabled_524 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_522R);
            IsEnabled_525 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_523F);
            IsEnabled_526 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_523R);
            IsEnabled_531 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_531F);
            IsEnabled_532 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_531R);
            IsEnabled_533 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_532F);
            IsEnabled_534 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_532R);
            IsEnabled_535 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_533F);
            IsEnabled_536 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_533R);
            IsEnabled_541 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_541F);
            IsEnabled_542 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_541R);
            IsEnabled_543 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_542F);
            IsEnabled_544 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_542R);
            IsEnabled_545 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_543F);
            IsEnabled_546 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_543R);
            IsEnabled_551 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_551F);
            IsEnabled_552 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_551R);
            IsEnabled_553 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_552F);
            IsEnabled_554 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_552R);
            IsEnabled_555 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_553F);
            IsEnabled_556 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_553R);


            IsEnabled_611 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_611F);
            IsEnabled_612 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_611R);
            IsEnabled_613 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_612F);
            IsEnabled_614 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_612R);
            IsEnabled_615 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_613F);
            IsEnabled_616 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_613R);
            IsEnabled_621 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_621F);
            IsEnabled_622 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_621R);
            IsEnabled_623 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_622F);
            IsEnabled_624 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_622R);
            IsEnabled_625 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_623F);
            IsEnabled_626 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_623R);
            IsEnabled_631 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_631F);
            IsEnabled_632 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_631R);
            IsEnabled_633 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_632F);
            IsEnabled_634 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_632R);
            IsEnabled_635 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_633F);
            IsEnabled_636 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_633R);
            IsEnabled_641 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_641F);
            IsEnabled_642 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_641R);
            IsEnabled_643 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_642F);
            IsEnabled_644 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_642R);
            IsEnabled_645 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_643F);
            IsEnabled_646 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_643R);
            IsEnabled_651 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_651F);
            IsEnabled_652 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_651R);
            IsEnabled_653 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_652F);
            IsEnabled_654 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_652R);
            IsEnabled_655 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_653F);
            IsEnabled_656 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_653R);

            IsEnabled_711 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_711F);
            IsEnabled_712 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_711R);
            IsEnabled_713 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_712F);
            IsEnabled_714 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_712R);
            IsEnabled_715 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_713F);
            IsEnabled_716 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_713R);
            IsEnabled_721 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_721F);
            IsEnabled_722 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_721R);
            IsEnabled_723 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_722F);
            IsEnabled_724 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_722R);
            IsEnabled_725 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_723F);
            IsEnabled_726 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_723R);
            IsEnabled_731 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_731F);
            IsEnabled_732 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_731R);
            IsEnabled_733 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_732F);
            IsEnabled_734 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_732R);
            IsEnabled_735 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_733F);
            IsEnabled_736 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_733R);
            IsEnabled_741 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_741F);
            IsEnabled_742 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_741R);
            IsEnabled_743 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_742F);
            IsEnabled_744 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_742R);
            IsEnabled_745 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_743F);
            IsEnabled_746 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_743R);
            IsEnabled_751 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_751F);
            IsEnabled_752 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_751R);
            IsEnabled_753 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_752F);
            IsEnabled_754 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_752R);
            IsEnabled_755 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_753F);
            IsEnabled_756 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_753R);


            IsEnabled_811 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_811F);
            IsEnabled_812 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_811R);
            IsEnabled_813 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_812F);
            IsEnabled_814 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_812R);
            IsEnabled_815 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_813F);
            IsEnabled_816 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_813R);
            IsEnabled_821 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_821F);
            IsEnabled_822 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_821R);
            IsEnabled_823 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_822F);
            IsEnabled_824 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_822R);
            IsEnabled_825 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_823F);
            IsEnabled_826 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_823R);
            IsEnabled_831 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_831F);
            IsEnabled_832 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_831R);
            IsEnabled_833 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_832F);
            IsEnabled_834 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_832R);
            IsEnabled_835 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_833F);
            IsEnabled_836 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_833R);
            IsEnabled_841 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_841F);
            IsEnabled_842 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_841R);
            IsEnabled_843 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_842F);
            IsEnabled_844 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_842R);
            IsEnabled_845 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_843F);
            IsEnabled_846 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_843R);
            IsEnabled_851 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_851F);
            IsEnabled_852 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_851R);
            IsEnabled_853 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_852F);
            IsEnabled_854 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_852R);
            IsEnabled_855 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_853F);
            IsEnabled_856 = GetStockBoxIsExist(IoNameHelper.iStock_nBox_853R);

            this.IsEnabled_btn_larva_level_0 = false;
            this.IsEnabled_btn_larva_level_1 = false;
            this.IsEnabled_btn_larva_level_2 = false;
            this.IsEnabled_btn_larva_level_3 = false;
            this.IsEnabled_btn_larva_level_4 = false;
            this.IsEnabled_btn_larva_level_5 = false;
            this.IsEnabled_btn_larva_level_6 = false;
            this.IsEnabled_btn_larva_level_7 = false;
        }

        void InitializeButtonStatus()
        {
            Name_Stock_111 = GetStockName("STOCK 1_11");    
            Name_Stock_112 = GetStockName("STOCK 1_12");
            Name_Stock_113 = GetStockName("STOCK 1_13");
            Name_Stock_114 = GetStockName("STOCK 1_14");
            Name_Stock_115 = GetStockName("STOCK 1_15");
            Name_Stock_116 = GetStockName("STOCK 1_16");
            Name_Stock_121 = GetStockName("STOCK 1_21");
            Name_Stock_122 = GetStockName("STOCK 1_22");
            Name_Stock_123 = GetStockName("STOCK 1_23");
            Name_Stock_124 = GetStockName("STOCK 1_24");
            Name_Stock_125 = GetStockName("STOCK 1_25");
            Name_Stock_126 = GetStockName("STOCK 1_26");
            Name_Stock_131 = GetStockName("STOCK 1_31");
            Name_Stock_132 = GetStockName("STOCK 1_32");
            Name_Stock_133 = GetStockName("STOCK 1_33");
            Name_Stock_134 = GetStockName("STOCK 1_34");
            Name_Stock_135 = GetStockName("STOCK 1_35");
            Name_Stock_136 = GetStockName("STOCK 1_36");
            Name_Stock_141 = GetStockName("STOCK 1_41");
            Name_Stock_142 = GetStockName("STOCK 1_42");
            Name_Stock_143 = GetStockName("STOCK 1_43");
            Name_Stock_144 = GetStockName("STOCK 1_44");
            Name_Stock_145 = GetStockName("STOCK 1_45");
            Name_Stock_146 = GetStockName("STOCK 1_46");
            Name_Stock_151 = GetStockName("STOCK 1_51");
            Name_Stock_152 = GetStockName("STOCK 1_52");
            Name_Stock_153 = GetStockName("STOCK 1_53");
            Name_Stock_154 = GetStockName("STOCK 1_54");
            Name_Stock_155 = GetStockName("STOCK 1_55");
            Name_Stock_156 = GetStockName("STOCK 1_56");

            Name_Stock_211 = GetStockName("STOCK 2_11");
            Name_Stock_212 = GetStockName("STOCK 2_12");
            Name_Stock_213 = GetStockName("STOCK 2_13");
            Name_Stock_214 = GetStockName("STOCK 2_14");
            Name_Stock_215 = GetStockName("STOCK 2_15");
            Name_Stock_216 = GetStockName("STOCK 2_16");
            Name_Stock_221 = GetStockName("STOCK 2_21");
            Name_Stock_222 = GetStockName("STOCK 2_22");
            Name_Stock_223 = GetStockName("STOCK 2_23");
            Name_Stock_224 = GetStockName("STOCK 2_24");
            Name_Stock_225 = GetStockName("STOCK 2_25");
            Name_Stock_226 = GetStockName("STOCK 2_26");
            Name_Stock_231 = GetStockName("STOCK 2_31");
            Name_Stock_232 = GetStockName("STOCK 2_32");
            Name_Stock_233 = GetStockName("STOCK 2_33");
            Name_Stock_234 = GetStockName("STOCK 2_34");
            Name_Stock_235 = GetStockName("STOCK 2_35");
            Name_Stock_236 = GetStockName("STOCK 2_36");
            Name_Stock_241 = GetStockName("STOCK 2_41");
            Name_Stock_242 = GetStockName("STOCK 2_42");
            Name_Stock_243 = GetStockName("STOCK 2_43");
            Name_Stock_244 = GetStockName("STOCK 2_44");
            Name_Stock_245 = GetStockName("STOCK 2_45");
            Name_Stock_246 = GetStockName("STOCK 2_46");
            Name_Stock_251 = GetStockName("STOCK 2_51");
            Name_Stock_252 = GetStockName("STOCK 2_52");
            Name_Stock_253 = GetStockName("STOCK 2_53");
            Name_Stock_254 = GetStockName("STOCK 2_54");
            Name_Stock_255 = GetStockName("STOCK 2_55");
            Name_Stock_256 = GetStockName("STOCK 2_56");

            Name_Stock_311 = GetStockName("STOCK 3_11");
            Name_Stock_312 = GetStockName("STOCK 3_12");
            Name_Stock_313 = GetStockName("STOCK 3_13");
            Name_Stock_314 = GetStockName("STOCK 3_14");
            Name_Stock_315 = GetStockName("STOCK 3_15");
            Name_Stock_316 = GetStockName("STOCK 3_16");
            Name_Stock_321 = GetStockName("STOCK 3_21");
            Name_Stock_322 = GetStockName("STOCK 3_22");
            Name_Stock_323 = GetStockName("STOCK 3_23");
            Name_Stock_324 = GetStockName("STOCK 3_24");
            Name_Stock_325 = GetStockName("STOCK 3_25");
            Name_Stock_326 = GetStockName("STOCK 3_26");
            Name_Stock_331 = GetStockName("STOCK 3_31");
            Name_Stock_332 = GetStockName("STOCK 3_32");
            Name_Stock_333 = GetStockName("STOCK 3_33");
            Name_Stock_334 = GetStockName("STOCK 3_34");
            Name_Stock_335 = GetStockName("STOCK 3_35");
            Name_Stock_336 = GetStockName("STOCK 3_36");
            Name_Stock_341 = GetStockName("STOCK 3_41");
            Name_Stock_342 = GetStockName("STOCK 3_42");
            Name_Stock_343 = GetStockName("STOCK 3_43");
            Name_Stock_344 = GetStockName("STOCK 3_44");
            Name_Stock_345 = GetStockName("STOCK 3_45");
            Name_Stock_346 = GetStockName("STOCK 3_46");
            Name_Stock_351 = GetStockName("STOCK 3_51");
            Name_Stock_352 = GetStockName("STOCK 3_52");
            Name_Stock_353 = GetStockName("STOCK 3_53");
            Name_Stock_354 = GetStockName("STOCK 3_54");
            Name_Stock_355 = GetStockName("STOCK 3_55");
            Name_Stock_356 = GetStockName("STOCK 3_56");

            Name_Stock_411 = GetStockName("STOCK 4_11");
            Name_Stock_412 = GetStockName("STOCK 4_12");
            Name_Stock_413 = GetStockName("STOCK 4_13");
            Name_Stock_414 = GetStockName("STOCK 4_14");
            Name_Stock_415 = GetStockName("STOCK 4_15");
            Name_Stock_416 = GetStockName("STOCK 4_16");
            Name_Stock_421 = GetStockName("STOCK 4_21");
            Name_Stock_422 = GetStockName("STOCK 4_22");
            Name_Stock_423 = GetStockName("STOCK 4_23");
            Name_Stock_424 = GetStockName("STOCK 4_24");
            Name_Stock_425 = GetStockName("STOCK 4_25");
            Name_Stock_426 = GetStockName("STOCK 4_26");
            Name_Stock_431 = GetStockName("STOCK 4_31");
            Name_Stock_432 = GetStockName("STOCK 4_32");
            Name_Stock_433 = GetStockName("STOCK 4_33");
            Name_Stock_434 = GetStockName("STOCK 4_34");
            Name_Stock_435 = GetStockName("STOCK 4_35");
            Name_Stock_436 = GetStockName("STOCK 4_36");
            Name_Stock_441 = GetStockName("STOCK 4_41");
            Name_Stock_442 = GetStockName("STOCK 4_42");
            Name_Stock_443 = GetStockName("STOCK 4_43");
            Name_Stock_444 = GetStockName("STOCK 4_44");
            Name_Stock_445 = GetStockName("STOCK 4_45");
            Name_Stock_446 = GetStockName("STOCK 4_46");
            Name_Stock_451 = GetStockName("STOCK 4_51");
            Name_Stock_452 = GetStockName("STOCK 4_52");
            Name_Stock_453 = GetStockName("STOCK 4_53");
            Name_Stock_454 = GetStockName("STOCK 4_54");
            Name_Stock_455 = GetStockName("STOCK 4_55");
            Name_Stock_456 = GetStockName("STOCK 4_56");

            Name_Stock_511 = GetStockName("STOCK 5_11");
            Name_Stock_512 = GetStockName("STOCK 5_12");
            Name_Stock_513 = GetStockName("STOCK 5_13");
            Name_Stock_514 = GetStockName("STOCK 5_14");
            Name_Stock_515 = GetStockName("STOCK 5_15");
            Name_Stock_516 = GetStockName("STOCK 5_16");
            Name_Stock_521 = GetStockName("STOCK 5_21");
            Name_Stock_522 = GetStockName("STOCK 5_22");
            Name_Stock_523 = GetStockName("STOCK 5_23");
            Name_Stock_524 = GetStockName("STOCK 5_24");
            Name_Stock_525 = GetStockName("STOCK 5_25");
            Name_Stock_526 = GetStockName("STOCK 5_26");
            Name_Stock_531 = GetStockName("STOCK 5_31");
            Name_Stock_532 = GetStockName("STOCK 5_32");
            Name_Stock_533 = GetStockName("STOCK 5_33");
            Name_Stock_534 = GetStockName("STOCK 5_34");
            Name_Stock_535 = GetStockName("STOCK 5_35");
            Name_Stock_536 = GetStockName("STOCK 5_36");
            Name_Stock_541 = GetStockName("STOCK 5_41");
            Name_Stock_542 = GetStockName("STOCK 5_42");
            Name_Stock_543 = GetStockName("STOCK 5_43");
            Name_Stock_544 = GetStockName("STOCK 5_44");
            Name_Stock_545 = GetStockName("STOCK 5_45");
            Name_Stock_546 = GetStockName("STOCK 5_46");
            Name_Stock_551 = GetStockName("STOCK 5_51");
            Name_Stock_552 = GetStockName("STOCK 5_52");
            Name_Stock_553 = GetStockName("STOCK 5_53");
            Name_Stock_554 = GetStockName("STOCK 5_54");
            Name_Stock_555 = GetStockName("STOCK 5_55");
            Name_Stock_556 = GetStockName("STOCK 5_56");

            Name_Stock_611 = GetStockName("STOCK 6_11");
            Name_Stock_612 = GetStockName("STOCK 6_12");
            Name_Stock_613 = GetStockName("STOCK 6_13");
            Name_Stock_614 = GetStockName("STOCK 6_14");
            Name_Stock_615 = GetStockName("STOCK 6_15");
            Name_Stock_616 = GetStockName("STOCK 6_16");
            Name_Stock_621 = GetStockName("STOCK 6_21");
            Name_Stock_622 = GetStockName("STOCK 6_22");
            Name_Stock_623 = GetStockName("STOCK 6_23");
            Name_Stock_624 = GetStockName("STOCK 6_24");
            Name_Stock_625 = GetStockName("STOCK 6_25");
            Name_Stock_626 = GetStockName("STOCK 6_26");
            Name_Stock_631 = GetStockName("STOCK 6_31");
            Name_Stock_632 = GetStockName("STOCK 6_32");
            Name_Stock_633 = GetStockName("STOCK 6_33");
            Name_Stock_634 = GetStockName("STOCK 6_34");
            Name_Stock_635 = GetStockName("STOCK 6_35");
            Name_Stock_636 = GetStockName("STOCK 6_36");
            Name_Stock_641 = GetStockName("STOCK 6_41");
            Name_Stock_642 = GetStockName("STOCK 6_42");
            Name_Stock_643 = GetStockName("STOCK 6_43");
            Name_Stock_644 = GetStockName("STOCK 6_44");
            Name_Stock_645 = GetStockName("STOCK 6_45");
            Name_Stock_646 = GetStockName("STOCK 6_46");
            Name_Stock_651 = GetStockName("STOCK 6_51");
            Name_Stock_652 = GetStockName("STOCK 6_52");
            Name_Stock_653 = GetStockName("STOCK 6_53");
            Name_Stock_654 = GetStockName("STOCK 6_54");
            Name_Stock_655 = GetStockName("STOCK 6_55");
            Name_Stock_656 = GetStockName("STOCK 6_56");

            Name_Stock_711 = GetStockName("STOCK 7_11");
            Name_Stock_712 = GetStockName("STOCK 7_12");
            Name_Stock_713 = GetStockName("STOCK 7_13");
            Name_Stock_714 = GetStockName("STOCK 7_14");
            Name_Stock_715 = GetStockName("STOCK 7_15");
            Name_Stock_716 = GetStockName("STOCK 7_16");
            Name_Stock_721 = GetStockName("STOCK 7_21");
            Name_Stock_722 = GetStockName("STOCK 7_22");
            Name_Stock_723 = GetStockName("STOCK 7_23");
            Name_Stock_724 = GetStockName("STOCK 7_24");
            Name_Stock_725 = GetStockName("STOCK 7_25");
            Name_Stock_726 = GetStockName("STOCK 7_26");
            Name_Stock_731 = GetStockName("STOCK 7_31");
            Name_Stock_732 = GetStockName("STOCK 7_32");
            Name_Stock_733 = GetStockName("STOCK 7_33");
            Name_Stock_734 = GetStockName("STOCK 7_34");
            Name_Stock_735 = GetStockName("STOCK 7_35");
            Name_Stock_736 = GetStockName("STOCK 7_36");
            Name_Stock_741 = GetStockName("STOCK 7_41");
            Name_Stock_742 = GetStockName("STOCK 7_42");
            Name_Stock_743 = GetStockName("STOCK 7_43");
            Name_Stock_744 = GetStockName("STOCK 7_44");
            Name_Stock_745 = GetStockName("STOCK 7_45");
            Name_Stock_746 = GetStockName("STOCK 7_46");
            Name_Stock_751 = GetStockName("STOCK 7_51");
            Name_Stock_752 = GetStockName("STOCK 7_52");
            Name_Stock_753 = GetStockName("STOCK 7_53");
            Name_Stock_754 = GetStockName("STOCK 7_54");
            Name_Stock_755 = GetStockName("STOCK 7_55");
            Name_Stock_756 = GetStockName("STOCK 7_56");

            Name_Stock_811 = GetStockName("STOCK 8_11");
            Name_Stock_812 = GetStockName("STOCK 8_12");
            Name_Stock_813 = GetStockName("STOCK 8_13");
            Name_Stock_814 = GetStockName("STOCK 8_14");
            Name_Stock_815 = GetStockName("STOCK 8_15");
            Name_Stock_816 = GetStockName("STOCK 8_16");
            Name_Stock_821 = GetStockName("STOCK 8_21");
            Name_Stock_822 = GetStockName("STOCK 8_22");
            Name_Stock_823 = GetStockName("STOCK 8_23");
            Name_Stock_824 = GetStockName("STOCK 8_24");
            Name_Stock_825 = GetStockName("STOCK 8_25");
            Name_Stock_826 = GetStockName("STOCK 8_26");
            Name_Stock_831 = GetStockName("STOCK 8_31");
            Name_Stock_832 = GetStockName("STOCK 8_32");
            Name_Stock_833 = GetStockName("STOCK 8_33");
            Name_Stock_834 = GetStockName("STOCK 8_34");
            Name_Stock_835 = GetStockName("STOCK 8_35");
            Name_Stock_836 = GetStockName("STOCK 8_36");
            Name_Stock_841 = GetStockName("STOCK 8_41");
            Name_Stock_842 = GetStockName("STOCK 8_42");
            Name_Stock_843 = GetStockName("STOCK 8_43");
            Name_Stock_844 = GetStockName("STOCK 8_44");
            Name_Stock_845 = GetStockName("STOCK 8_45");
            Name_Stock_846 = GetStockName("STOCK 8_46");
            Name_Stock_851 = GetStockName("STOCK 8_51");
            Name_Stock_852 = GetStockName("STOCK 8_52");
            Name_Stock_853 = GetStockName("STOCK 8_53");
            Name_Stock_854 = GetStockName("STOCK 8_54");
            Name_Stock_855 = GetStockName("STOCK 8_55");
            Name_Stock_856 = GetStockName("STOCK 8_56");

            Name_btn_larva_level_0 = "미설정";
            Name_btn_larva_level_1 = "성충";
            Name_btn_larva_level_2 = "알";
            Name_btn_larva_level_3 = "1~2령";
            Name_btn_larva_level_4 = "3령";
            Name_btn_larva_level_5 = "3령 금식";
            Name_btn_larva_level_6 = "3령 출하";
            Name_btn_larva_level_7 = "코쿤";
        }
    }
}
