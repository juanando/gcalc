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
    string ver="1.2";
    string[] misname = new string[255];
    int[] misgold = new int[255];
   
    int n;

    public Form1()
    {
      InitializeComponent();

      this.Text="Gold Calculator - v"+ver;


      // load arrays:
      misgold[0]=523;	misname[0]="1.1- Ashen Road";
      misgold[1]=621;	misname[1]="1.2- Glades of Silence ";
      misgold[2]=643;	misname[2]="1.3- Dry Dale ";
      misgold[3]=659;	misname[3]="1.4- Smoky Crossroads ";
      misgold[4]=641;	misname[4]="1.5- Merchant Camp ";
      misgold[5]=687;	misname[5]="1.6- City Gate ";
      misgold[6]=701;	misname[6]="1.7- City on Fire ";
      misgold[7]=742;	misname[7]="1.8- Scorching Pavement ";
      misgold[8]=761;	misname[8]="1.9- Elder's House ";
      misgold[9]=1923;	misname[9]="1.10- Archdemon's Patrimony ";
      misgold[10]=695;	misname[10]="2.1- Wilheim ";
      misgold[11]=786;	misname[11]="2.2- Reaper's Cabin ";
      misgold[12]=791;	misname[12]="2.3- Outskirts ";
      misgold[13]=772;	misname[13]="2.4- Overgrown Path ";
      misgold[14]=804;	misname[14]="2.5- Thick Forest ";
      misgold[15]=813;	misname[15]="2.6- Outskirts of Wilheim ";
      misgold[16]=823;	misname[16]="2.7- Monolith of Meron ";
      misgold[17]=815;	misname[17]="2.8- Secret Ford ";
      misgold[18]=839;	misname[18]="2.9- River of Oblivion ";
      misgold[19]=822;	misname[19]="2.10- Magic Thicket ";
      misgold[20]=818;	misname[20]="2.11- Marax' Trace ";
      misgold[21]=841;	misname[21]="2.12- Nameless Road ";
      misgold[22]=825;	misname[22]="2.13- Deadlands ";
      misgold[23]=817;	misname[23]="2.14- Seal of Fire ";
      misgold[24]=827;	misname[24]="2.15- Lava Fracture ";
      misgold[25]=843;	misname[25]="3.1- Outpost ";
      misgold[26]=832;	misname[26]="3.2- Rocky Wasteland ";
      misgold[27]=846;	misname[27]="3.3- Grog's Stairway ";
      misgold[28]=827;	misname[28]="3.4- Dusty Cliff ";
      misgold[29]=853;	misname[29]="3.5- Rotten Ravine ";
      misgold[30]=851;	misname[30]="3.6- Living Mountains ";
      misgold[31]=861;	misname[31]="3.7- Dilapidated Bridge ";
      misgold[32]=893;	misname[32]="3.8- Scorched Lands ";
      misgold[33]=872;	misname[33]="3.9- Road of Mourning ";
      misgold[34]=849;	misname[34]="3.10- Sanctuary of The Ancestors ";
      misgold[35]=864;	misname[35]="3.11- Fir Valley ";
      misgold[36]=873;	misname[36]="3.12- Camp Approach ";
      misgold[37]=862;	misname[37]="3.13- Orcish Patrol ";
      misgold[38]=893;	misname[38]="3.14- Frontier Camp ";
      misgold[39]=2523;	misname[39]="3.15- Leader's Tent ";
      misgold[40]=1223;	misname[40]="4.1- Shepherds' Lands ";
      misgold[41]=1093;	misname[41]="4.2- Dry Wind ";
      misgold[42]=1023;	misname[42]="4.3- Edge of Dusk ";
      misgold[43]=1036;	misname[43]="4.4- Surrounding Highway ";
      misgold[44]=1074;	misname[44]="4.5- Trial by Darkness ";
      misgold[45]=1058;	misname[45]="4.6- Burnt Canyon ";
      misgold[46]=1019;	misname[46]="4.7- Ashes and Coal ";
      misgold[47]=1054;	misname[47]="4.8- At Worlds' End ";
      misgold[48]=1039;	misname[48]="4.9- Bottomless Chasm ";
      misgold[49]=1033;	misname[49]="4.10- Necropolis ";
      misgold[50]=1064;	misname[50]="4.11- Granite of Silence ";
      misgold[51]=1081;	misname[51]="4.12- Death Shroud ";
      misgold[52]=1072;	misname[52]="4.13- In the Afterlife ";
      misgold[53]=1093;	misname[53]="4.14- Atrium ";
      misgold[54]=1084;	misname[54]="4.15- Gravehall Estate ";
      misgold[55]=1056;	misname[55]="5.1- Smagard Terraces ";
      misgold[56]=1072;	misname[56]="5.2- Obelisk ";
      misgold[57]=1073;	misname[57]="5.3- Emerald Dust ";
      misgold[58]=1088;	misname[58]="5.4- Exit from Gravehall ";
      misgold[59]=1029;	misname[59]="5.5- Blinding Light ";
      misgold[60]=1126;	misname[60]="5.6- Flourishing Life ";
      misgold[61]=1043;	misname[61]="5.7- Poisonous Lashes ";
      misgold[62]=1038;	misname[62]="5.8- Hemlock Thicket ";
      misgold[63]=1042;	misname[63]="5.9- Dangerous Shores ";
      misgold[64]=1109;	misname[64]="5.10- Drowner's Bridge ";
      misgold[65]=1083;	misname[65]="5.11- Uninvited Guest ";
      misgold[66]=1092;	misname[66]="5.12- Enemy Hearth ";
      misgold[67]=1063;	misname[67]="5.13- Halt ";
      misgold[68]=1077;	misname[68]="5.14- Purple Wilds ";
      misgold[69]=1829;	misname[69]="5.15- Illwood ";
      misgold[70]=1053;	misname[70]="6.1- Backwater ";
      misgold[71]=1161;	misname[71]="6.2- Wretched Goosefoot ";
      misgold[72]=1082;	misname[72]="6.3- Bogger ";
      misgold[73]=1094;	misname[73]="6.4- Damp Area ";
      misgold[74]=1033;	misname[74]="6.5- Mandrake Flowers ";
      misgold[75]=1139;	misname[75]="6.6- Forlorn Churchyard ";
      misgold[76]=1107;	misname[76]="6.7- Frigid Place ";
      misgold[77]=1126;	misname[77]="6.8- Misty Cliff ";
      misgold[78]=1131;	misname[78]="6.9- Morth Chrone's Lands ";
      misgold[79]=1182;	misname[79]="6.10- Ritual Circle ";
      misgold[80]=1167;	misname[80]="6.11- Tarrot's Arches ";
      misgold[81]=1183;	misname[81]="6.12- Eternal Night ";
      misgold[82]=1129;	misname[82]="6.13- Game of Shadows ";
      misgold[83]=1145;	misname[83]="6.14- Trapper's Nets ";
      misgold[84]=2736;	misname[84]="6.15- Thorn Arches ";
      misgold[85]=1164;	misname[85]="7.1- Toll Gate ";
      misgold[86]=1267;	misname[86]="7.2- Weapon Stands ";
      misgold[87]=1281;	misname[87]="7.3- Gnawed Bones ";
      misgold[88]=1263;	misname[88]="7.4- Torchlit Passage ";
      misgold[89]=1309;	misname[89]="7.5- Training Fields ";
      misgold[90]=1384;	misname[90]="7.6- Blood of the Earth ";
      misgold[91]=1247;	misname[91]="7.7- Blood and Sweat ";
      misgold[92]=1291;	misname[92]="7.8- Break of Times ";
      misgold[93]=1316;	misname[93]="7.9- Bridge over the Chasm ";
      misgold[94]=1319;	misname[94]="7.10- Titan Plains ";
      misgold[95]=1254;	misname[95]="7.11- Battle of Santar ";
      misgold[96]=1283;	misname[96]="7.12- Great Split ";
      misgold[97]=1296;	misname[97]="7.13- Path of War ";
      misgold[98]=1273;	misname[98]="7.14- Mortal Wound ";
      misgold[99]=1327;	misname[99]="7.15- Burial Mound ";
      misgold[100]=1422;	misname[100]="8.1- Fire-Worshippers' Capital ";
      misgold[101]=1352;	misname[101]="8.2- Monolith of Guile ";
      misgold[102]=1301;	misname[102]="8.3- Anthracite Palace ";
      misgold[103]=1364;	misname[103]="8.4- Basalts ";
      misgold[104]=1382;	misname[104]="8.5- Monolith of Deceit ";
      misgold[105]=1474;	misname[105]="8.6- Soul of the Volcano ";
      misgold[106]=1338;	misname[106]="8.7- Monolith of Enmity ";
      misgold[107]=1419;	misname[107]="8.8- Foundry ";
      misgold[108]=1362;	misname[108]="8.9- Torture Chamber ";
      misgold[109]=1421;	misname[109]="8.10- Flaming Gates ";
      misgold[110]=1423;	misname[110]="8.11- Monolith of Pain ";
      misgold[111]=1376;	misname[111]="8.12- Monolith of Groans ";
      misgold[112]=1388;	misname[112]="8.13- Shore of Despair ";
      misgold[113]=1375;	misname[113]="8.14- Lava River ";
      misgold[114]=3523;	misname[114]="8.15- Furnace of Horror ";
      misgold[115]=2631;	misname[115]="9.1- Shore ";
      misgold[116]=1311;	misname[116]="9.2- Abandoned Lighthouse ";
      misgold[117]=1415;	misname[117]="9.3- Sea Lanes ";
      misgold[118]=1497;	misname[118]="9.4- Grig's Strand ";
      misgold[119]=1463;	misname[119]="9.5- Mainland ";
      misgold[120]=2733;	misname[120]="9.6- Treasure Island ";
      misgold[121]=1523;	misname[121]="9.7- Dunes ";
      misgold[122]=1517;	misname[122]="9.8- Cape of Despair ";
      misgold[123]=1548;	misname[123]="9.9- Transit Point ";
      misgold[124]=2519;	misname[124]="9.10- Pirate Den ";
      misgold[125]=1488;	misname[125]="9.11- Secret Route ";
      misgold[126]=1478;	misname[126]="9.12- Pariah's Mooring ";
      misgold[127]=1489;	misname[127]="9.13- Warstream ";
      misgold[128]=1503;	misname[128]="9.14- Dead Man's Strait ";
      misgold[129]=2499;	misname[129]="9.15- Coral Reef ";
      misgold[130]=2537;	misname[130]="10.1- Flying Dutchman ";
      misgold[131]=1511;	misname[131]="10.2- Shipwreck ";
      misgold[132]=1564;	misname[132]="10.3- Rough Sea ";
      misgold[133]=1535;	misname[133]="10.4- Outer Vortex ";
      misgold[134]=1521;	misname[134]="10.5- Roaring Abyss ";
      misgold[135]=2436;	misname[135]="10.6- Whirlpool ";
      misgold[136]=1551;	misname[136]="10.7- Salvation's Run ";
      misgold[137]=1523;	misname[137]="10.8- Strait of Fortune ";
      misgold[138]=1561;	misname[138]="10.9- Seaman's Song ";
      misgold[139]=2519;	misname[139]="10.10- Sirens ";
      misgold[140]=1503;	misname[140]="10.11- Becalmed Waters ";
      misgold[141]=1572;	misname[141]="10.12- Shallow Waters ";
      misgold[142]=1543;	misname[142]="10.13- Sea Lane ";
      misgold[143]=1529;	misname[143]="10.14- Dark Waters ";
      misgold[144]=3787;	misname[144]="10.15- Kraken's Cave ";
      misgold[145]=3700;	misname[145]="11.1- Longship Moorings ";
      misgold[146]=1855;	misname[146]="11.2- Old Docks ";
      misgold[147]=1860;	misname[147]="11.3- Jorn's Hut ";
      misgold[148]=1864;	misname[148]="11.4- Worn Rut ";
      misgold[149]=1870;	misname[149]="11.5- Mark of Doom ";
      misgold[150]=3750;	misname[150]="11.6- Grimling Camp ";
      misgold[151]=1879;	misname[151]="11.7- Mountain Tunnel ";
      misgold[152]=1884;	misname[152]="11.8- The Bear Corner ";
      misgold[153]=1889;	misname[153]="11.9- Hunters' Dugouts ";
      misgold[154]=3786;	misname[154]="11.10- Doomsdale ";
      misgold[155]=1899;	misname[155]="11.11- Everfrost ";
      misgold[156]=1904;	misname[156]="11.12- Cold Ridge ";
      misgold[157]=1908;	misname[157]="11.13- Berserker Gorge ";
      misgold[158]=1914;	misname[158]="11.14- Crystal Waters ";
      misgold[159]=5752;	misname[159]="11.15- Gunar the Ferocious's Grotto ";
      misgold[160]=3845;	misname[160]="12.1- Glass Lake ";
      misgold[161]=1927;	misname[161]="12.2- Depths of Solitude ";
      misgold[162]=1933;	misname[162]="12.3- A Slippery Path ";
      misgold[163]=1938;	misname[163]="12.4- Ice Ridges ";
      misgold[164]=1942;	misname[164]="12.5- Labyrinth of Past Hopes ";
      misgold[165]=3894;	misname[165]="12.6- The Lost Wonder ";
      misgold[166]=1952;	misname[166]="12.7- Cliff Path ";
      misgold[167]=1958;	misname[167]="12.8- Frigid Place ";
      misgold[168]=1963;	misname[168]="12.9- Cold Fire ";
      misgold[169]=3935;	misname[169]="12.10- Runic Millstone ";
      misgold[170]=1972;	misname[170]="12.11- Guardian Border ";
      misgold[171]=1977;	misname[171]="12.12- Touch of the Frost ";
      misgold[172]=1982;	misname[172]="12.13- Path of the Skalds ";
      misgold[173]=1986;	misname[173]="12.14- Path of the Skalds ";
      misgold[174]=5977;	misname[174]="12.15- Jarl's Estate ";
      misgold[175]=1998;	misname[175]="13.1- Perilous Pass ";
      misgold[176]=4003;	misname[176]="13.2- Wolfsfang Cliff ";
      misgold[177]=2006;	misname[177]="13.3- Stone Steps ";
      misgold[178]=2012;	misname[178]="13.4- Unhappy Meeting ";
      misgold[179]=2017;	misname[179]="13.5- Hangman's Crossing ";
      misgold[180]=4044;	misname[180]="13.6- Stonemasons' Village ";
      misgold[181]=2026;	misname[181]="13.7- Thawed Snow ";
      misgold[182]=2032;	misname[182]="13.8- Dangerous Ravine ";
      misgold[183]=2037;	misname[183]="13.9- Warmer, Warmer ";
      misgold[184]=4085;	misname[184]="13.10- Valley of Geysers ";
      misgold[185]=2047;	misname[185]="13.11- Fetid Springs ";
      misgold[186]=2053;	misname[186]="13.12- Feast ";
      misgold[187]=2059;	misname[187]="13.13- Distribution ";
      misgold[188]=2063;	misname[188]="13.14- Crystal Bridge ";
      misgold[189]=6201;	misname[189]="13.15- Escape from Winter ";
      misgold[190]=2067;	misname[190]="14.1- Ghirwil City Terraces ";
      misgold[191]=2071;	misname[191]="14.2- The Constructs ";
      misgold[192]=4126;	misname[192]="14.3- Communications Center ";
      misgold[193]=2075;	misname[193]="14.4- The Shrieking Drill Tavern ";
      misgold[194]=2079;	misname[194]="14.5- Square of the Three Masters ";
      misgold[195]=2083;	misname[195]="14.6- Halls of the Communes ";
      misgold[196]=2087;	misname[196]="14.7- Ghirwil Print Printing Office ";
      misgold[197]=4167;	misname[197]="14.8- Runaway Princess ";
      misgold[198]=2091;	misname[198]="14.9- Path of Madness ";
      misgold[199]=2095;	misname[199]="14.10- Handcrafted Wonder ";
      misgold[200]=2099;	misname[200]="14.11- Deadly Height ";
      misgold[201]=3003;	misname[201]="14.12- Into the Abyss ";
      misgold[202]=6425;	misname[202]="14.13- Heart of the Capital ";
      misgold[203]=0;	misname[203]="14.14- Tank ";
      misgold[204]=4208;	misname[204]="14.15- Technical Division ";
      misgold[205]=4249;	misname[205]="15.1- Dromm Plateau ";
      misgold[206]=3011;	misname[206]="15.2- Constructor's Cliff ";
      misgold[207]=3015;	misname[207]="15.3- Floors of Grim Musings ";
      misgold[208]=3019;	misname[208]="15.4- Depth 1114 ";
      misgold[209]=3023;	misname[209]="15.5- Forge of the Perfect ";
      misgold[210]=3027;	misname[210]="15.6- All the Colors of the Elements ";
      misgold[211]=0;	misname[211]="15.7- Elemental Spirit Asylum ";
      misgold[212]=3031;	misname[212]="15.8- Careful Steps ";
      misgold[213]=3035;	misname[213]="15.9- Light of Love ";
      misgold[214]=3039;	misname[214]="15.10- Over the Rainbow ";
      misgold[215]=4290;	misname[215]="15.11- Proving Ground ";
      misgold[216]=3043;	misname[216]="15.12- Path of Estrangement ";
      misgold[217]=3047;	misname[217]="15.13- Worst Premonitions ";
      misgold[218]=3051;	misname[218]="15.14- Endless Abyss ";
      misgold[219]=6649;	misname[219]="15.15- Eternal Darkness ";

      n = 220;



    }

    private void button2_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }


    private void calculate()
    {
      // get goldvalue
      try
      {
        int gold = int.Parse(textBox1.Text);
        int tao = gold % 1000; // complete this to a multiple of 100
        int hund;
        int goldsum;

        //status.Text += "with gold= " + gold.ToString() + "\n";
        //status.Text += "mod 1000 = " + tao.ToString() + "\n";

        status.Text += "scanning missions: \n";
        status.Text += "idx   gt   \tmod     \tgm  \tmission-name\n";
        // scan all missisons:
        for(int i=0;i<n;i++)
        {
          if(misgold[i]!=0)
          {
            goldsum = gold + misgold[i];
            tao = goldsum % 1000;
            hund = goldsum % 100;

            if (hund == 0 || hund == 50)
            {
              status.Text += "[" + i.ToString("000") + "] " + goldsum.ToString() +":\t(" +hund.ToString() + ")\t" + misgold[i].ToString() + "\t[" + misname[i] + "]\n";
            }
          }
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
