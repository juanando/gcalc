using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hero_gold
{
  public partial class Form1 : Form
  {    
    string ver="1.3";
    string[] misname = new string[255];
    int[] misgold = new int[255];
    int[] misene = new int[255];
    int[] mislev = new int[255];
   
    int n;

    public Form1()
    {
      InitializeComponent();

      this.Text="Gold Calculator - v"+ver;


      // load arrays:
      misgold[0]=523;	misname[0]="1.1- Ashen Road";	misene[0]=12;	mislev[0]=1;
      misgold[1]=621;	misname[1]="1.2- Glades of Silence ";	misene[1]=6;	mislev[1]=1;
      misgold[2]=643;	misname[2]="1.3- Dry Dale ";	misene[2]=6;	mislev[2]=1;
      misgold[3]=659;	misname[3]="1.4- Smoky Crossroads ";	misene[3]=6;	mislev[3]=1;
      misgold[4]=641;	misname[4]="1.5- Merchant Camp ";	misene[4]=12;	mislev[4]=1;
      misgold[5]=687;	misname[5]="1.6- City Gate ";	misene[5]=6;	mislev[5]=1;
      misgold[6]=701;	misname[6]="1.7- City on Fire ";	misene[6]=6;	mislev[6]=1;
      misgold[7]=742;	misname[7]="1.8- Scorching Pavement ";	misene[7]=6;	mislev[7]=1;
      misgold[8]=761;	misname[8]="1.9- Elder's House ";	misene[8]=6;	mislev[8]=1;
      misgold[9]=1923;	misname[9]="1.10- Archdemon's Patrimony ";	misene[9]=18;	mislev[9]=1;
      misgold[10]=695;	misname[10]="2.1- Wilheim ";	misene[10]=12;	mislev[10]=2;
      misgold[11]=786;	misname[11]="2.2- Reaper's Cabin ";	misene[11]=6;	mislev[11]=2;
      misgold[12]=791;	misname[12]="2.3- Outskirts ";	misene[12]=6;	mislev[12]=2;
      misgold[13]=772;	misname[13]="2.4- Overgrown Path ";	misene[13]=6;	mislev[13]=2;
      misgold[14]=804;	misname[14]="2.5- Thick Forest ";	misene[14]=6;	mislev[14]=2;
      misgold[15]=813;	misname[15]="2.6- Outskirts of Wilheim ";	misene[15]=12;	mislev[15]=2;
      misgold[16]=823;	misname[16]="2.7- Monolith of Meron ";	misene[16]=6;	mislev[16]=2;
      misgold[17]=815;	misname[17]="2.8- Secret Ford ";	misene[17]=6;	mislev[17]=2;
      misgold[18]=839;	misname[18]="2.9- River of Oblivion ";	misene[18]=6;	mislev[18]=2;
      misgold[19]=822;	misname[19]="2.10- Magic Thicket ";	misene[19]=12;	mislev[19]=2;
      misgold[20]=818;	misname[20]="2.11- Marax' Trace ";	misene[20]=6;	mislev[20]=2;
      misgold[21]=841;	misname[21]="2.12- Nameless Road ";	misene[21]=6;	mislev[21]=2;
      misgold[22]=825;	misname[22]="2.13- Deadlands ";	misene[22]=6;	mislev[22]=2;
      misgold[23]=817;	misname[23]="2.14- Seal of Fire ";	misene[23]=6;	mislev[23]=2;
      misgold[24]=827;	misname[24]="2.15- Lava Fracture ";	misene[24]=12;	mislev[24]=2;
      misgold[25]=843;	misname[25]="3.1- Outpost ";	misene[25]=12;	mislev[25]=3;
      misgold[26]=832;	misname[26]="3.2- Rocky Wasteland ";	misene[26]=6;	mislev[26]=3;
      misgold[27]=846;	misname[27]="3.3- Grog's Stairway ";	misene[27]=6;	mislev[27]=3;
      misgold[28]=827;	misname[28]="3.4- Dusty Cliff ";	misene[28]=6;	mislev[28]=3;
      misgold[29]=853;	misname[29]="3.5- Rotten Ravine ";	misene[29]=6;	mislev[29]=3;
      misgold[30]=851;	misname[30]="3.6- Living Mountains ";	misene[30]=12;	mislev[30]=3;
      misgold[31]=861;	misname[31]="3.7- Dilapidated Bridge ";	misene[31]=6;	mislev[31]=3;
      misgold[32]=893;	misname[32]="3.8- Scorched Lands ";	misene[32]=6;	mislev[32]=3;
      misgold[33]=872;	misname[33]="3.9- Road of Mourning ";	misene[33]=6;	mislev[33]=3;
      misgold[34]=849;	misname[34]="3.10- Sanctuary of The Ancestors ";	misene[34]=12;	mislev[34]=3;
      misgold[35]=864;	misname[35]="3.11- Fir Valley ";	misene[35]=6;	mislev[35]=3;
      misgold[36]=873;	misname[36]="3.12- Camp Approach ";	misene[36]=6;	mislev[36]=3;
      misgold[37]=862;	misname[37]="3.13- Orcish Patrol ";	misene[37]=6;	mislev[37]=3;
      misgold[38]=893;	misname[38]="3.14- Frontier Camp ";	misene[38]=6;	mislev[38]=3;
      misgold[39]=2523;	misname[39]="3.15- Leader's Tent ";	misene[39]=18;	mislev[39]=3;
      misgold[40]=1223;	misname[40]="4.1- Shepherds' Lands ";	misene[40]=12;	mislev[40]=4;
      misgold[41]=1093;	misname[41]="4.2- Dry Wind ";	misene[41]=6;	mislev[41]=4;
      misgold[42]=1023;	misname[42]="4.3- Edge of Dusk ";	misene[42]=6;	mislev[42]=4;
      misgold[43]=1036;	misname[43]="4.4- Surrounding Highway ";	misene[43]=6;	mislev[43]=4;
      misgold[44]=1074;	misname[44]="4.5- Trial by Darkness ";	misene[44]=6;	mislev[44]=4;
      misgold[45]=1058;	misname[45]="4.6- Burnt Canyon ";	misene[45]=12;	mislev[45]=4;
      misgold[46]=1019;	misname[46]="4.7- Ashes and Coal ";	misene[46]=6;	mislev[46]=4;
      misgold[47]=1054;	misname[47]="4.8- At Worlds' End ";	misene[47]=6;	mislev[47]=4;
      misgold[48]=1039;	misname[48]="4.9- Bottomless Chasm ";	misene[48]=6;	mislev[48]=4;
      misgold[49]=1033;	misname[49]="4.10- Necropolis ";	misene[49]=12;	mislev[49]=4;
      misgold[50]=1064;	misname[50]="4.11- Granite of Silence ";	misene[50]=6;	mislev[50]=4;
      misgold[51]=1081;	misname[51]="4.12- Death Shroud ";	misene[51]=6;	mislev[51]=4;
      misgold[52]=1072;	misname[52]="4.13- In the Afterlife ";	misene[52]=6;	mislev[52]=4;
      misgold[53]=1093;	misname[53]="4.14- Atrium ";	misene[53]=6;	mislev[53]=4;
      misgold[54]=1084;	misname[54]="4.15- Gravehall Estate ";	misene[54]=12;	mislev[54]=4;
      misgold[55]=1056;	misname[55]="5.1- Smagard Terraces ";	misene[55]=6;	mislev[55]=5;
      misgold[56]=1072;	misname[56]="5.2- Obelisk ";	misene[56]=12;	mislev[56]=5;
      misgold[57]=1073;	misname[57]="5.3- Emerald Dust ";	misene[57]=6;	mislev[57]=5;
      misgold[58]=1088;	misname[58]="5.4- Exit from Gravehall ";	misene[58]=6;	mislev[58]=5;
      misgold[59]=1029;	misname[59]="5.5- Blinding Light ";	misene[59]=6;	mislev[59]=5;
      misgold[60]=1126;	misname[60]="5.6- Flourishing Life ";	misene[60]=12;	mislev[60]=5;
      misgold[61]=1043;	misname[61]="5.7- Poisonous Lashes ";	misene[61]=6;	mislev[61]=5;
      misgold[62]=1038;	misname[62]="5.8- Hemlock Thicket ";	misene[62]=6;	mislev[62]=5;
      misgold[63]=1042;	misname[63]="5.9- Dangerous Shores ";	misene[63]=6;	mislev[63]=5;
      misgold[64]=1109;	misname[64]="5.10- Drowner's Bridge ";	misene[64]=12;	mislev[64]=5;
      misgold[65]=1083;	misname[65]="5.11- Uninvited Guest ";	misene[65]=6;	mislev[65]=5;
      misgold[66]=1092;	misname[66]="5.12- Enemy Hearth ";	misene[66]=6;	mislev[66]=5;
      misgold[67]=1063;	misname[67]="5.13- Halt ";	misene[67]=6;	mislev[67]=5;
      misgold[68]=1077;	misname[68]="5.14- Purple Wilds ";	misene[68]=6;	mislev[68]=5;
      misgold[69]=1829;	misname[69]="5.15- Illwood ";	misene[69]=18;	mislev[69]=5;
      misgold[70]=1053;	misname[70]="6.1- Backwater ";	misene[70]=6;	mislev[70]=6;
      misgold[71]=1161;	misname[71]="6.2- Wretched Goosefoot ";	misene[71]=12;	mislev[71]=6;
      misgold[72]=1082;	misname[72]="6.3- Bogger ";	misene[72]=6;	mislev[72]=6;
      misgold[73]=1094;	misname[73]="6.4- Damp Area ";	misene[73]=6;	mislev[73]=6;
      misgold[74]=1033;	misname[74]="6.5- Mandrake Flowers ";	misene[74]=6;	mislev[74]=6;
      misgold[75]=1139;	misname[75]="6.6- Forlorn Churchyard ";	misene[75]=12;	mislev[75]=6;
      misgold[76]=1107;	misname[76]="6.7- Frigid Place ";	misene[76]=6;	mislev[76]=6;
      misgold[77]=1126;	misname[77]="6.8- Misty Cliff ";	misene[77]=6;	mislev[77]=6;
      misgold[78]=1131;	misname[78]="6.9- Morth Chrone's Lands ";	misene[78]=6;	mislev[78]=6;
      misgold[79]=1182;	misname[79]="6.10- Ritual Circle ";	misene[79]=12;	mislev[79]=6;
      misgold[80]=1167;	misname[80]="6.11- Tarrot's Arches ";	misene[80]=6;	mislev[80]=6;
      misgold[81]=1183;	misname[81]="6.12- Eternal Night ";	misene[81]=6;	mislev[81]=6;
      misgold[82]=1129;	misname[82]="6.13- Game of Shadows ";	misene[82]=6;	mislev[82]=6;
      misgold[83]=1145;	misname[83]="6.14- Trapper's Nets ";	misene[83]=6;	mislev[83]=6;
      misgold[84]=2736;	misname[84]="6.15- Thorn Arches ";	misene[84]=18;	mislev[84]=6;
      misgold[85]=1164;	misname[85]="7.1- Toll Gate ";	misene[85]=16;	mislev[85]=7;
      misgold[86]=1267;	misname[86]="7.2- Weapon Stands ";	misene[86]=8;	mislev[86]=7;
      misgold[87]=1281;	misname[87]="7.3- Gnawed Bones ";	misene[87]=8;	mislev[87]=7;
      misgold[88]=1263;	misname[88]="7.4- Torchlit Passage ";	misene[88]=8;	mislev[88]=7;
      misgold[89]=1309;	misname[89]="7.5- Training Fields ";	misene[89]=8;	mislev[89]=7;
      misgold[90]=1384;	misname[90]="7.6- Blood of the Earth ";	misene[90]=16;	mislev[90]=7;
      misgold[91]=1247;	misname[91]="7.7- Blood and Sweat ";	misene[91]=8;	mislev[91]=7;
      misgold[92]=1291;	misname[92]="7.8- Break of Times ";	misene[92]=8;	mislev[92]=7;
      misgold[93]=1316;	misname[93]="7.9- Bridge over the Chasm ";	misene[93]=8;	mislev[93]=7;
      misgold[94]=1319;	misname[94]="7.10- Titan Plains ";	misene[94]=16;	mislev[94]=7;
      misgold[95]=1254;	misname[95]="7.11- Battle of Santar ";	misene[95]=8;	mislev[95]=7;
      misgold[96]=1283;	misname[96]="7.12- Great Split ";	misene[96]=8;	mislev[96]=7;
      misgold[97]=1296;	misname[97]="7.13- Path of War ";	misene[97]=8;	mislev[97]=7;
      misgold[98]=1273;	misname[98]="7.14- Mortal Wound ";	misene[98]=8;	mislev[98]=7;
      misgold[99]=1327;	misname[99]="7.15- Burial Mound ";	misene[99]=16;	mislev[99]=7;
      misgold[100]=1422;	misname[100]="8.1- Fire-Worshippers' Capital ";	misene[100]=16;	mislev[100]=8;
      misgold[101]=1352;	misname[101]="8.2- Monolith of Guile ";	misene[101]=8;	mislev[101]=8;
      misgold[102]=1301;	misname[102]="8.3- Anthracite Palace ";	misene[102]=8;	mislev[102]=8;
      misgold[103]=1364;	misname[103]="8.4- Basalts ";	misene[103]=8;	mislev[103]=8;
      misgold[104]=1382;	misname[104]="8.5- Monolith of Deceit ";	misene[104]=8;	mislev[104]=8;
      misgold[105]=1474;	misname[105]="8.6- Soul of the Volcano ";	misene[105]=16;	mislev[105]=8;
      misgold[106]=1338;	misname[106]="8.7- Monolith of Enmity ";	misene[106]=8;	mislev[106]=8;
      misgold[107]=1419;	misname[107]="8.8- Foundry ";	misene[107]=8;	mislev[107]=8;
      misgold[108]=1362;	misname[108]="8.9- Torture Chamber ";	misene[108]=8;	mislev[108]=8;
      misgold[109]=1421;	misname[109]="8.10- Flaming Gates ";	misene[109]=16;	mislev[109]=8;
      misgold[110]=1423;	misname[110]="8.11- Monolith of Pain ";	misene[110]=8;	mislev[110]=8;
      misgold[111]=1376;	misname[111]="8.12- Monolith of Groans ";	misene[111]=8;	mislev[111]=8;
      misgold[112]=1388;	misname[112]="8.13- Shore of Despair ";	misene[112]=8;	mislev[112]=8;
      misgold[113]=1375;	misname[113]="8.14- Lava River ";	misene[113]=8;	mislev[113]=8;
      misgold[114]=3523;	misname[114]="8.15- Furnace of Horror ";	misene[114]=24;	mislev[114]=8;
      misgold[115]=2631;	misname[115]="9.1- Shore ";	misene[115]=16;	mislev[115]=9;
      misgold[116]=1311;	misname[116]="9.2- Abandoned Lighthouse ";	misene[116]=8;	mislev[116]=9;
      misgold[117]=1415;	misname[117]="9.3- Sea Lanes ";	misene[117]=8;	mislev[117]=9;
      misgold[118]=1497;	misname[118]="9.4- Grig's Strand ";	misene[118]=8;	mislev[118]=9;
      misgold[119]=1463;	misname[119]="9.5- Mainland ";	misene[119]=8;	mislev[119]=9;
      misgold[120]=2733;	misname[120]="9.6- Treasure Island ";	misene[120]=16;	mislev[120]=9;
      misgold[121]=1523;	misname[121]="9.7- Dunes ";	misene[121]=8;	mislev[121]=9;
      misgold[122]=1517;	misname[122]="9.8- Cape of Despair ";	misene[122]=8;	mislev[122]=9;
      misgold[123]=1548;	misname[123]="9.9- Transit Point ";	misene[123]=8;	mislev[123]=9;
      misgold[124]=2519;	misname[124]="9.10- Pirate Den ";	misene[124]=16;	mislev[124]=9;
      misgold[125]=1488;	misname[125]="9.11- Secret Route ";	misene[125]=8;	mislev[125]=9;
      misgold[126]=1478;	misname[126]="9.12- Pariah's Mooring ";	misene[126]=8;	mislev[126]=9;
      misgold[127]=1489;	misname[127]="9.13- Warstream ";	misene[127]=8;	mislev[127]=9;
      misgold[128]=1503;	misname[128]="9.14- Dead Man's Strait ";	misene[128]=8;	mislev[128]=9;
      misgold[129]=2499;	misname[129]="9.15- Coral Reef ";	misene[129]=16;	mislev[129]=9;
      misgold[130]=2537;	misname[130]="10.1- Flying Dutchman ";	misene[130]=16;	mislev[130]=10;
      misgold[131]=1511;	misname[131]="10.2- Shipwreck ";	misene[131]=8;	mislev[131]=10;
      misgold[132]=1564;	misname[132]="10.3- Rough Sea ";	misene[132]=8;	mislev[132]=10;
      misgold[133]=1535;	misname[133]="10.4- Outer Vortex ";	misene[133]=8;	mislev[133]=10;
      misgold[134]=1521;	misname[134]="10.5- Roaring Abyss ";	misene[134]=8;	mislev[134]=10;
      misgold[135]=2436;	misname[135]="10.6- Whirlpool ";	misene[135]=16;	mislev[135]=10;
      misgold[136]=1551;	misname[136]="10.7- Salvation's Run ";	misene[136]=8;	mislev[136]=10;
      misgold[137]=1523;	misname[137]="10.8- Strait of Fortune ";	misene[137]=8;	mislev[137]=10;
      misgold[138]=1561;	misname[138]="10.9- Seaman's Song ";	misene[138]=8;	mislev[138]=10;
      misgold[139]=2519;	misname[139]="10.10- Sirens ";	misene[139]=16;	mislev[139]=10;
      misgold[140]=1503;	misname[140]="10.11- Becalmed Waters ";	misene[140]=8;	mislev[140]=10;
      misgold[141]=1572;	misname[141]="10.12- Shallow Waters ";	misene[141]=8;	mislev[141]=10;
      misgold[142]=1543;	misname[142]="10.13- Sea Lane ";	misene[142]=8;	mislev[142]=10;
      misgold[143]=1529;	misname[143]="10.14- Dark Waters ";	misene[143]=8;	mislev[143]=10;
      misgold[144]=3787;	misname[144]="10.15- Kraken's Cave ";	misene[144]=24;	mislev[144]=10;
      misgold[145]=3700;	misname[145]="11.1- Longship Moorings ";	misene[145]=20;	mislev[145]=11;
      misgold[146]=1855;	misname[146]="11.2- Old Docks ";	misene[146]=10;	mislev[146]=11;
      misgold[147]=1860;	misname[147]="11.3- Jorn's Hut ";	misene[147]=10;	mislev[147]=11;
      misgold[148]=1864;	misname[148]="11.4- Worn Rut ";	misene[148]=10;	mislev[148]=11;
      misgold[149]=1870;	misname[149]="11.5- Mark of Doom ";	misene[149]=10;	mislev[149]=11;
      misgold[150]=3750;	misname[150]="11.6- Grimling Camp ";	misene[150]=20;	mislev[150]=11;
      misgold[151]=1879;	misname[151]="11.7- Mountain Tunnel ";	misene[151]=10;	mislev[151]=11;
      misgold[152]=1884;	misname[152]="11.8- The Bear Corner ";	misene[152]=10;	mislev[152]=11;
      misgold[153]=1889;	misname[153]="11.9- Hunters' Dugouts ";	misene[153]=10;	mislev[153]=11;
      misgold[154]=3786;	misname[154]="11.10- Doomsdale ";	misene[154]=20;	mislev[154]=11;
      misgold[155]=1899;	misname[155]="11.11- Everfrost ";	misene[155]=10;	mislev[155]=11;
      misgold[156]=1904;	misname[156]="11.12- Cold Ridge ";	misene[156]=10;	mislev[156]=11;
      misgold[157]=1908;	misname[157]="11.13- Berserker Gorge ";	misene[157]=10;	mislev[157]=11;
      misgold[158]=1914;	misname[158]="11.14- Crystal Waters ";	misene[158]=10;	mislev[158]=11;
      misgold[159]=5752;	misname[159]="11.15- Gunar the Ferocious's Grotto ";	misene[159]=30;	mislev[159]=11;
      misgold[160]=3845;	misname[160]="12.1- Glass Lake ";	misene[160]=20;	mislev[160]=12;
      misgold[161]=1927;	misname[161]="12.2- Depths of Solitude ";	misene[161]=10;	mislev[161]=12;
      misgold[162]=1933;	misname[162]="12.3- A Slippery Path ";	misene[162]=10;	mislev[162]=12;
      misgold[163]=1938;	misname[163]="12.4- Ice Ridges ";	misene[163]=10;	mislev[163]=12;
      misgold[164]=1942;	misname[164]="12.5- Labyrinth of Past Hopes ";	misene[164]=10;	mislev[164]=12;
      misgold[165]=3894;	misname[165]="12.6- The Lost Wonder ";	misene[165]=20;	mislev[165]=12;
      misgold[166]=1952;	misname[166]="12.7- Cliff Path ";	misene[166]=10;	mislev[166]=12;
      misgold[167]=1958;	misname[167]="12.8- Frigid Place ";	misene[167]=10;	mislev[167]=12;
      misgold[168]=1963;	misname[168]="12.9- Cold Fire ";	misene[168]=10;	mislev[168]=12;
      misgold[169]=3935;	misname[169]="12.10- Runic Millstone ";	misene[169]=20;	mislev[169]=12;
      misgold[170]=1972;	misname[170]="12.11- Guardian Border ";	misene[170]=10;	mislev[170]=12;
      misgold[171]=1977;	misname[171]="12.12- Touch of the Frost ";	misene[171]=10;	mislev[171]=12;
      misgold[172]=1982;	misname[172]="12.13- Path of the Skalds ";	misene[172]=10;	mislev[172]=12;
      misgold[173]=1986;	misname[173]="12.14- Path of the Skalds ";	misene[173]=10;	mislev[173]=12;
      misgold[174]=5977;	misname[174]="12.15- Jarl's Estate ";	misene[174]=30;	mislev[174]=12;
      misgold[175]=1998;	misname[175]="13.1- Perilous Pass ";	misene[175]=10;	mislev[175]=13;
      misgold[176]=4003;	misname[176]="13.2- Wolfsfang Cliff ";	misene[176]=20;	mislev[176]=13;
      misgold[177]=2006;	misname[177]="13.3- Stone Steps ";	misene[177]=10;	mislev[177]=13;
      misgold[178]=2012;	misname[178]="13.4- Unhappy Meeting ";	misene[178]=10;	mislev[178]=13;
      misgold[179]=2017;	misname[179]="13.5- Hangman's Crossing ";	misene[179]=10;	mislev[179]=13;
      misgold[180]=4044;	misname[180]="13.6- Stonemasons' Village ";	misene[180]=20;	mislev[180]=13;
      misgold[181]=2026;	misname[181]="13.7- Thawed Snow ";	misene[181]=10;	mislev[181]=13;
      misgold[182]=2032;	misname[182]="13.8- Dangerous Ravine ";	misene[182]=10;	mislev[182]=13;
      misgold[183]=2037;	misname[183]="13.9- Warmer, Warmer ";	misene[183]=10;	mislev[183]=13;
      misgold[184]=4085;	misname[184]="13.10- Valley of Geysers ";	misene[184]=20;	mislev[184]=13;
      misgold[185]=2047;	misname[185]="13.11- Fetid Springs ";	misene[185]=10;	mislev[185]=13;
      misgold[186]=2053;	misname[186]="13.12- Feast ";	misene[186]=10;	mislev[186]=13;
      misgold[187]=2059;	misname[187]="13.13- Distribution ";	misene[187]=10;	mislev[187]=13;
      misgold[188]=2063;	misname[188]="13.14- Crystal Bridge ";	misene[188]=10;	mislev[188]=13;
      misgold[189]=6201;	misname[189]="13.15- Escape from Winter ";	misene[189]=24;	mislev[189]=13;
      misgold[190]=2067;	misname[190]="14.1- Ghirwil City Terraces ";	misene[190]=10;	mislev[190]=14;
      misgold[191]=2071;	misname[191]="14.2- The Constructs ";	misene[191]=10;	mislev[191]=14;
      misgold[192]=4126;	misname[192]="14.3- Communications Center ";	misene[192]=20;	mislev[192]=14;
      misgold[193]=2075;	misname[193]="14.4- The 'Shrieking Drill'  Tavern ";	misene[193]=10;	mislev[193]=14;
      misgold[194]=2079;	misname[194]="14.5- Square of the Three Masters ";	misene[194]=10;	mislev[194]=14;
      misgold[195]=2083;	misname[195]="14.6- Halls of the Communes ";	misene[195]=10;	mislev[195]=14;
      misgold[196]=2087;	misname[196]="14.7- Ghirwil Print Printing Office ";	misene[196]=10;	mislev[196]=14;
      misgold[197]=4167;	misname[197]="14.8- Runaway Princess ";	misene[197]=20;	mislev[197]=14;
      misgold[198]=2091;	misname[198]="14.9- Path of Madness ";	misene[198]=10;	mislev[198]=14;
      misgold[199]=2095;	misname[199]="14.10- Handcrafted Wonder ";	misene[199]=10;	mislev[199]=14;
      misgold[200]=2099;	misname[200]="14.11- Deadly Height ";	misene[200]=10;	mislev[200]=14;
      misgold[201]=3003;	misname[201]="14.12- Into the Abyss ";	misene[201]=10;	mislev[201]=14;
      misgold[202]=6425;	misname[202]="14.13- Heart of the Capital ";	misene[202]=24;	mislev[202]=14;
      misgold[203]=0;	misname[203]="14.14- Tank ";	misene[203]=0;	mislev[203]=14;
      misgold[204]=4208;	misname[204]="14.15- Technical Division ";	misene[204]=20;	mislev[204]=14;
      misgold[205]=4249;	misname[205]="15.1- Dromm Plateau ";	misene[205]=20;	mislev[205]=15;
      misgold[206]=3011;	misname[206]="15.2- Constructor's Cliff ";	misene[206]=10;	mislev[206]=15;
      misgold[207]=3015;	misname[207]="15.3- Floors of Grim Musings ";	misene[207]=10;	mislev[207]=15;
      misgold[208]=3019;	misname[208]="15.4- Depth 1114 ";	misene[208]=10;	mislev[208]=15;
      misgold[209]=3023;	misname[209]="15.5- Forge of the Perfect ";	misene[209]=20;	mislev[209]=15;
      misgold[210]=3027;	misname[210]="15.6- All the Colors of the Elements ";	misene[210]=10;	mislev[210]=15;
      misgold[211]=0;	misname[211]="15.7- Elemental Spirit Asylum ";	misene[211]=0;	mislev[211]=15;
      misgold[212]=3031;	misname[212]="15.8- Careful Steps ";	misene[212]=10;	mislev[212]=15;
      misgold[213]=3035;	misname[213]="15.9- Light of Love ";	misene[213]=10;	mislev[213]=15;
      misgold[214]=3039;	misname[214]="15.10- Over the Rainbow ";	misene[214]=10;	mislev[214]=15;
      misgold[215]=4290;	misname[215]="15.11- Proving Ground ";	misene[215]=20;	mislev[215]=15;
      misgold[216]=3043;	misname[216]="15.12- Path of Estrangement ";	misene[216]=10;	mislev[216]=15;
      misgold[217]=3047;	misname[217]="15.13- Worst Premonitions ";	misene[217]=10;	mislev[217]=15;
      misgold[218]=3051;	misname[218]="15.14- Endless Abyss ";	misene[218]=10;	mislev[218]=15;
      misgold[219]=6649;	misname[219]="15.15- Eternal Darkness ";	misene[219]=30;	mislev[219]=15;



      n = 220;



    }

    private void button2_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }


    private void calculate()
    {
      int i, j;
      int found = 0;

      // get goldvalue
      try
      {
        int gold = int.Parse(textBox1.Text);
        int tao = gold % 1000; // complete this to a multiple of 100
        int hund;
        int goldsum;
        int maxlev;

        //status.Text += "with gold= " + gold.ToString() + "\n";
        //status.Text += "mod 1000 = " + tao.ToString() + "\n";

        maxlev = int.Parse(textBoxlev.Text);
        status.Text += "max level = " + maxlev.ToString() + "\n";


        
        status.Text += "scanning missions: \n";
        status.Text += "1 pass ------------------------------------------------------------\n";
        status.Text += "idx   gt   \tmod     \tgm  \tene \tmission-name\n";
        
        
        found = 0;
        for (i = 0; i < n; i++)
        {
          if (misgold[i] != 0 && mislev[i] <= maxlev)
          {
            goldsum = gold + misgold[i];
            tao = goldsum % 1000;
            hund = goldsum % 100;

            if (hund == 0 || hund == 50)
            {
              status.Text += "[" + i.ToString("000") + "] " +
                             goldsum.ToString() + ":\t(" + hund.ToString() + ")\t" +
                             misgold[i].ToString() + "\t[" + misene[i].ToString() + "]\t[" + misname[i] + "]\n";
              found++;
            }
          }
        }
        status.Text += "found= "+found.ToString()+"\n";

        if (found == 0)
        {
          status.Text += "2 pass ------------------------------------------------------------\n";
          status.Text += "idx   gt   \tmod     \tgm  \tene \tmission-name\n";
          found = 0;
          for (i = 0; i < n; i++)
            if (misgold[i] != 0 && mislev[i] <= maxlev)
              for (j = i; j < n; j++)
              {

                if (misgold[j] != 0 && mislev[j] <= maxlev)
                {
                  goldsum = gold + misgold[i] + misgold[j];
                  tao = goldsum % 1000;
                  hund = goldsum % 100;

                  if (hund == 0 || hund == 50)
                  {
                    status.Text += "[" + i.ToString("000") + "][" + j.ToString("000") + "] " +
                                   goldsum.ToString() + ":\t(" + hund.ToString() + ")\t" +
                                   misgold[i].ToString() + "," + misgold[j].ToString() + 
                                   "\t[" + misene[i].ToString() + "," + misene[j].ToString() + "]\t[" +
                                   misname[i] + "," + misname[j] + "]\n";
                    found++;
                  }
                }
              }
          status.Text += "found= " + found.ToString() + "\n";
        }


      }
      catch
      {
        status.Text += "no number\n";
      }
    }



    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        status.Text="searching to complete a multiple of 50 or 100...\n";

        calculate();

      }
    }

    private void buttongo_Click(object sender, EventArgs e)
    {
      status.Text = "searching to complete a multiple of 50 or 100...\n";

      calculate();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
