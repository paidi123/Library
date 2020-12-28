using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Bestiary;
using Terraria.ID;

namespace Terraria
{
	// Token: 0x0200000F RID: 15
	public partial class Chest
	{
		// Token: 0x0600008D RID: 141 RVA: 0x0002B4E0 File Offset: 0x000296E0
		public void SetupShop(int type)
		{
			bool flag = Main.LocalPlayer.currentShoppingSettings.PriceAdjustment <= 0.8500000238418579;
			Item[] array = this.item;
			for (int i = 0; i < 40; i++)
			{
				array[i] = new Item();
			}
			int num = 0;
			if (type == 1)
			{
				if (Main.dayTime)
				{
					array[num++].SetDefaults(1786);
					array[num++].SetDefaults(87);
					array[num++].SetDefaults(35);
					array[num++].SetDefaults(3183);
					array[num++].SetDefaults(1333);
					array[num++].SetDefaults(499);
					array[num++].SetDefaults(500);
					array[num++].SetDefaults(1334);
					array[num++].SetDefaults(965);
					array[num++].SetDefaults(29);
					array[num++].SetDefaults(1291);
					array[num++].SetDefaults(109);
					array[num++].SetDefaults(3318);
					array[num++].SetDefaults(3319);
					array[num++].SetDefaults(3320);
					array[num++].SetDefaults(3321);
					array[num++].SetDefaults(3322);
					array[num++].SetDefaults(3323);
					array[num++].SetDefaults(3324);
					array[num++].SetDefaults(3325);
					array[num++].SetDefaults(3326);
					array[num++].SetDefaults(3327);
					array[num++].SetDefaults(3328);
					array[num++].SetDefaults(3329);
					array[num++].SetDefaults(3330);
					array[num++].SetDefaults(3331);
					array[num++].SetDefaults(3332);
					array[num++].SetDefaults(3860);
					array[num++].SetDefaults(4782);
					array[num++].SetDefaults(4957);
					array[num++].SetDefaults(4956);
				}
				if (!Main.dayTime)
				{
					array[num++].SetDefaults(282);
					array[num++].SetDefaults(967);
					array[num++].SetDefaults(33);
					array[num++].SetDefaults(4074);
					array[num++].SetDefaults(279);
					array[num++].SetDefaults(346);
					array[num++].SetDefaults(488);
					array[num++].SetDefaults(931);
					array[num++].SetDefaults(1614);
					array[num++].SetDefaults(1348);
					array[num++].SetDefaults(4063);
					array[num++].SetDefaults(4673);
					array[num++].SetDefaults(3108);
					array[num++].SetDefaults(12);
					array[num++].SetDefaults(699);
					array[num++].SetDefaults(11);
					array[num++].SetDefaults(700);
					array[num++].SetDefaults(14);
					array[num++].SetDefaults(116);
					array[num++].SetDefaults(701);
					array[num++].SetDefaults(174);
					array[num++].SetDefaults(13);
					array[num++].SetDefaults(702);
					array[num++].SetDefaults(364);
					array[num++].SetDefaults(1104);
				}
			}
			else if (type == 2)
			{
				array[num++].SetDefaults(97);
				array[num++].SetDefaults(4915);
				array[num++].SetDefaults(278);
				array[num++].SetDefaults(47);
				array[num++].SetDefaults(95);
				array[num++].SetDefaults(98);
				array[num++].SetDefaults(4703);
				array[num++].SetDefaults(324);
				array[num++].SetDefaults(534);
				array[num++].SetDefaults(1432);
				array[num++].SetDefaults(1261);
				array[num++].SetDefaults(1836);
				array[num++].SetDefaults(3108);
				array[num++].SetDefaults(1783);
				array[num++].SetDefaults(1785);
				array[num++].SetDefaults(1736);
				array[num++].SetDefaults(1737);
				array[num++].SetDefaults(1738);
			}
			else if (type == 3)
			{
				if (Main.dayTime)
				{
					array[num++].SetDefaults(2886);
					array[num++].SetDefaults(2171);
					array[num++].SetDefaults(4508);
					array[num++].SetDefaults(67);
					array[num++].SetDefaults(59);
					array[num++].SetDefaults(4504);
					array[num++].SetDefaults(66);
					array[num++].SetDefaults(62);
					array[num++].SetDefaults(63);
					array[num++].SetDefaults(745);
					array[num++].SetDefaults(59);
					array[num++].SetDefaults(2171);
					array[num++].SetDefaults(27);
					array[num++].SetDefaults(114);
					array[num++].SetDefaults(1828);
					array[num++].SetDefaults(747);
					array[num++].SetDefaults(746);
					array[num++].SetDefaults(369);
					array[num++].SetDefaults(4505);
					array[num++].SetDefaults(194);
				}
				if (!Main.dayTime)
				{
					array[num++].SetDefaults(1853);
					array[num++].SetDefaults(1854);
					array[num++].SetDefaults(3215);
					array[num++].SetDefaults(3216);
					array[num++].SetDefaults(3219);
					array[num++].SetDefaults(3218);
					array[num++].SetDefaults(3217);
					array[num++].SetDefaults(3220);
					array[num++].SetDefaults(3221);
					array[num++].SetDefaults(3222);
					array[num++].SetDefaults(4047);
					array[num++].SetDefaults(4045);
					array[num++].SetDefaults(4044);
					array[num++].SetDefaults(4043);
					array[num++].SetDefaults(4042);
					array[num++].SetDefaults(4046);
					array[num++].SetDefaults(4041);
					array[num++].SetDefaults(4241);
					array[num++].SetDefaults(4048);
					array[num++].SetDefaults(4430);
					array[num++].SetDefaults(4431);
					array[num++].SetDefaults(4432);
					array[num++].SetDefaults(4433);
					array[num++].SetDefaults(4434);
					array[num++].SetDefaults(4435);
					array[num++].SetDefaults(4436);
					array[num++].SetDefaults(4437);
					array[num++].SetDefaults(4438);
					array[num++].SetDefaults(4439);
					array[num++].SetDefaults(4440);
					array[num++].SetDefaults(4441);
				}
			}
			else if (type == 4)
			{
				array[num++].SetDefaults(168);
				array[num++].SetDefaults(166);
				array[num++].SetDefaults(167);
				array[num++].SetDefaults(265);
				array[num++].SetDefaults(937);
				array[num++].SetDefaults(1347);
				array[num++].SetDefaults(4827);
				array[num++].SetDefaults(4824);
				array[num++].SetDefaults(4825);
				array[num++].SetDefaults(4826);
			}
			else if (type == 5)
			{
				if (Main.dayTime)
				{
					array[num++].SetDefaults(254);
					array[num++].SetDefaults(981);
					array[num++].SetDefaults(242);
					array[num++].SetDefaults(245);
					array[num++].SetDefaults(246);
					array[num++].SetDefaults(1288);
					array[num++].SetDefaults(1289);
					array[num++].SetDefaults(325);
					array[num++].SetDefaults(326);
					array[num++].SetDefaults(269);
					array[num++].SetDefaults(270);
					array[num++].SetDefaults(271);
					array[num++].SetDefaults(503);
					array[num++].SetDefaults(504);
					array[num++].SetDefaults(505);
					array[num++].SetDefaults(322);
					array[num++].SetDefaults(3362);
					array[num++].SetDefaults(3363);
					array[num++].SetDefaults(2856);
					array[num++].SetDefaults(2858);
					array[num++].SetDefaults(2857);
					array[num++].SetDefaults(2859);
					array[num++].SetDefaults(3242);
					array[num++].SetDefaults(3243);
					array[num++].SetDefaults(3244);
				}
				if (!Main.dayTime)
				{
					array[num++].SetDefaults(4685);
					array[num++].SetDefaults(4686);
					array[num++].SetDefaults(4704);
					array[num++].SetDefaults(4705);
					array[num++].SetDefaults(4706);
					array[num++].SetDefaults(4707);
					array[num++].SetDefaults(4708);
					array[num++].SetDefaults(4709);
					array[num++].SetDefaults(1429);
					array[num++].SetDefaults(1740);
					array[num++].SetDefaults(869);
					array[num++].SetDefaults(4994);
					array[num++].SetDefaults(4997);
					array[num++].SetDefaults(864);
					array[num++].SetDefaults(865);
					array[num++].SetDefaults(4995);
					array[num++].SetDefaults(4998);
					array[num++].SetDefaults(873);
					array[num++].SetDefaults(874);
					array[num++].SetDefaults(875);
					array[num++].SetDefaults(4996);
					array[num++].SetDefaults(4999);
					array[num++].SetDefaults(1275);
					array[num++].SetDefaults(1276);
					array[num++].SetDefaults(3246);
					array[num++].SetDefaults(3247);
					array[num++].SetDefaults(3730);
					array[num++].SetDefaults(3731);
					array[num++].SetDefaults(3733);
					array[num++].SetDefaults(3734);
					array[num++].SetDefaults(3735);
					array[num++].SetDefaults(4744);
				}
			}
			else if (type == 6)
			{
				array[num++].SetDefaults(128);
				array[num++].SetDefaults(486);
				array[num++].SetDefaults(398);
				array[num++].SetDefaults(84);
				array[num++].SetDefaults(407);
				array[num++].SetDefaults(161);
			}
			else if (type == 7)
			{
				array[num++].SetDefaults(487);
				array[num++].SetDefaults(496);
				array[num++].SetDefaults(500);
				array[num++].SetDefaults(507);
				array[num++].SetDefaults(508);
				array[num++].SetDefaults(531);
				array[num++].SetDefaults(576);
				array[num++].SetDefaults(3186);
				array[num++].SetDefaults(1739);
			}
			else if (type == 8)
			{
				array[num++].SetDefaults(509);
				array[num++].SetDefaults(850);
				array[num++].SetDefaults(851);
				array[num++].SetDefaults(3612);
				array[num++].SetDefaults(510);
				array[num++].SetDefaults(530);
				array[num++].SetDefaults(513);
				array[num++].SetDefaults(538);
				array[num++].SetDefaults(529);
				array[num++].SetDefaults(541);
				array[num++].SetDefaults(542);
				array[num++].SetDefaults(543);
				array[num++].SetDefaults(852);
				array[num++].SetDefaults(853);
				array[num++].SetDefaults(4261);
				array[num++].SetDefaults(3707);
				array[num++].SetDefaults(2739);
				array[num++].SetDefaults(849);
				array[num++].SetDefaults(3616);
				array[num++].SetDefaults(2799);
				array[num++].SetDefaults(3619);
				array[num++].SetDefaults(3627);
				array[num++].SetDefaults(3629);
				array[num++].SetDefaults(4484);
				array[num++].SetDefaults(4485);
				array[num++].SetDefaults(2295);
			}
			else if (type == 9)
			{
				array[num++].SetDefaults(588);
				array[num++].SetDefaults(589);
				array[num++].SetDefaults(590);
				array[num++].SetDefaults(597);
				array[num++].SetDefaults(598);
				array[num++].SetDefaults(596);
				for (int j = 1873; j < 1906; j++)
				{
					array[num++].SetDefaults(j);
				}
			}
			else if (type == 10)
			{
				array[num++].SetDefaults(756);
				array[num++].SetDefaults(787);
				array[num++].SetDefaults(868);
				array[num++].SetDefaults(1551);
				array[num++].SetDefaults(1181);
				array[num++].SetDefaults(783);
			}
			else if (type == 11)
			{
				array[num++].SetDefaults(779);
				array[num++].SetDefaults(748);
				array[num++].SetDefaults(839);
				array[num++].SetDefaults(840);
				array[num++].SetDefaults(841);
				array[num++].SetDefaults(948);
				array[num++].SetDefaults(3623);
				array[num++].SetDefaults(3603);
				array[num++].SetDefaults(3604);
				array[num++].SetDefaults(3607);
				array[num++].SetDefaults(3605);
				array[num++].SetDefaults(3606);
				array[num++].SetDefaults(3608);
				array[num++].SetDefaults(3618);
				array[num++].SetDefaults(3602);
				array[num++].SetDefaults(3663);
				array[num++].SetDefaults(3609);
				array[num++].SetDefaults(3610);
				array[num++].SetDefaults(995);
				array[num++].SetDefaults(2203);
				array[num++].SetDefaults(2193);
				array[num++].SetDefaults(4142);
				array[num++].SetDefaults(1263);
				array[num++].SetDefaults(784);
				array[num++].SetDefaults(782);
				array[num++].SetDefaults(781);
				array[num++].SetDefaults(780);
				array[num++].SetDefaults(1344);
				array[num++].SetDefaults(4472);
				array[num++].SetDefaults(1742);
			}
			else if (type == 12)
			{
				array[num++].SetDefaults(1037);
				array[num++].SetDefaults(2874);
				array[num++].SetDefaults(1120);
				array[num++].SetDefaults(1969);
				array[num++].SetDefaults(3248);
				array[num++].SetDefaults(1741);
				array[num++].SetDefaults(2871);
				array[num++].SetDefaults(2872);
				array[num++].SetDefaults(4663);
				array[num++].SetDefaults(4662);
			}
			else if (type == 13)
			{
				array[num++].SetDefaults(859);
				array[num++].SetDefaults(4743);
				array[num++].SetDefaults(1000);
				array[num++].SetDefaults(1168);
				array[num++].SetDefaults(1449);
				array[num++].SetDefaults(4552);
				array[num++].SetDefaults(1345);
				array[num++].SetDefaults(1450);
				array[num++].SetDefaults(3253);
				array[num++].SetDefaults(4553);
				array[num++].SetDefaults(2700);
				array[num++].SetDefaults(2738);
				array[num++].SetDefaults(4470);
				array[num++].SetDefaults(4681);
				array[num++].SetDefaults(4682);
				array[num++].SetDefaults(4702);
				array[num++].SetDefaults(3548);
				array[num++].SetDefaults(3369);
				array[num++].SetDefaults(3546);
				array[num++].SetDefaults(3214);
				array[num++].SetDefaults(2868);
				array[num++].SetDefaults(970);
				array[num++].SetDefaults(971);
				array[num++].SetDefaults(972);
				array[num++].SetDefaults(973);
				array[num++].SetDefaults(4791);
				array[num++].SetDefaults(3747);
				array[num++].SetDefaults(3732);
				array[num++].SetDefaults(3742);
				array[num++].SetDefaults(3749);
				array[num++].SetDefaults(3746);
				array[num++].SetDefaults(3739);
				array[num++].SetDefaults(3740);
				array[num++].SetDefaults(3741);
				array[num++].SetDefaults(3737);
				array[num++].SetDefaults(3738);
				array[num++].SetDefaults(3736);
				array[num++].SetDefaults(3745);
				array[num++].SetDefaults(3744);
				array[num++].SetDefaults(3743);
			}
			else if (type == 14)
			{
				array[num++].SetDefaults(771);
				array[num++].SetDefaults(772);
				array[num++].SetDefaults(773);
				array[num++].SetDefaults(774);
				array[num++].SetDefaults(4445);
				array[num++].SetDefaults(4446);
				array[num++].SetDefaults(4459);
				array[num++].SetDefaults(760);
				array[num++].SetDefaults(1346);
				array[num++].SetDefaults(4409);
				array[num++].SetDefaults(4392);
				array[num++].SetDefaults(1743);
				array[num++].SetDefaults(1744);
				array[num++].SetDefaults(1745);
				array[num++].SetDefaults(2862);
				array[num++].SetDefaults(3109);
				array[num++].SetDefaults(3664);
			}
			else if (type == 15)
			{
				if (Main.dayTime)
				{
					array[num++].SetDefaults(1071);
					array[num++].SetDefaults(1072);
					array[num++].SetDefaults(1100);
					for (int k = 1073; k <= 1084; k++)
					{
						array[num++].SetDefaults(k);
					}
					array[num++].SetDefaults(1097);
					array[num++].SetDefaults(1099);
					array[num++].SetDefaults(1098);
					array[num++].SetDefaults(1966);
					array[num++].SetDefaults(4668);
					array[num++].SetDefaults(1967);
					array[num++].SetDefaults(1968);
					array[num++].SetDefaults(1490);
					array[num++].SetDefaults(1481);
					array[num++].SetDefaults(1482);
					array[num++].SetDefaults(1483);
					array[num++].SetDefaults(1484);
					array[num++].SetDefaults(1492);
					array[num++].SetDefaults(1488);
					array[num++].SetDefaults(1489);
					array[num++].SetDefaults(1486);
					array[num++].SetDefaults(1487);
					array[num++].SetDefaults(1491);
					array[num++].SetDefaults(1493);
					array[num++].SetDefaults(1485);
				}
				if (!Main.dayTime)
				{
					array[num++].SetDefaults(1494);
					array[num++].SetDefaults(4723);
					array[num++].SetDefaults(4724);
					array[num++].SetDefaults(4725);
					array[num++].SetDefaults(4726);
					array[num++].SetDefaults(4727);
					array[num++].SetDefaults(4728);
					array[num++].SetDefaults(4729);
					for (int l = 1948; l <= 1957; l++)
					{
						array[num++].SetDefaults(l);
					}
					for (int m = 2158; m <= 2160; m++)
					{
						if (num < 39)
						{
							array[num].SetDefaults(m);
						}
						num++;
					}
					for (int n = 2008; n <= 2014; n++)
					{
						if (num < 39)
						{
							array[num].SetDefaults(n);
						}
						num++;
					}
				}
			}
			else if (type == 16)
			{
				array[num++].SetDefaults(1430);
				array[num++].SetDefaults(986);
				array[num++].SetDefaults(2999);
				array[num++].SetDefaults(1159);
				array[num++].SetDefaults(1160);
				array[num++].SetDefaults(1161);
				array[num++].SetDefaults(1158);
				array[num++].SetDefaults(1167);
				array[num++].SetDefaults(1339);
				array[num++].SetDefaults(1171);
				array[num++].SetDefaults(1162);
				array[num++].SetDefaults(909);
				array[num++].SetDefaults(910);
				array[num++].SetDefaults(940);
				array[num++].SetDefaults(941);
				array[num++].SetDefaults(942);
				array[num++].SetDefaults(943);
				array[num++].SetDefaults(944);
				array[num++].SetDefaults(945);
				array[num++].SetDefaults(4922);
				array[num++].SetDefaults(4417);
				array[num++].SetDefaults(1836);
				array[num++].SetDefaults(1261);
				array[num++].SetDefaults(1791);
			}
			else if (type == 17)
			{
				array[num++].SetDefaults(928);
				array[num++].SetDefaults(929);
				array[num++].SetDefaults(876);
				array[num++].SetDefaults(877);
				array[num++].SetDefaults(878);
				array[num++].SetDefaults(2434);
				array[num++].SetDefaults(1180);
				array[num++].SetDefaults(1337);
			}
			else if (type == 18)
			{
				array[num++].SetDefaults(1990);
				array[num++].SetDefaults(1979);
				array[num++].SetDefaults(1977);
				array[num++].SetDefaults(1978);
				array[num++].SetDefaults(1980);
				array[num++].SetDefaults(1981);
				array[num++].SetDefaults(1982);
				array[num++].SetDefaults(1983);
				array[num++].SetDefaults(1984);
				array[num++].SetDefaults(1985);
				array[num++].SetDefaults(1986);
				array[num++].SetDefaults(2863);
				array[num++].SetDefaults(3259);
			}
			else if (type == 19)
			{
				for (int num2 = 0; num2 < 40; num2++)
				{
					if (Main.travelShop[num2] != 0)
					{
						array[num].netDefaults(Main.travelShop[num2]);
						num++;
					}
				}
			}
			else if (type == 20)
			{
				array[num].SetDefaults(3001);
				array[num].SetDefaults(28);
				array[num].SetDefaults(3002);
				array[num].SetDefaults(282);
				array[num].SetDefaults(3004);
				array[num].SetDefaults(8);
				array[num].SetDefaults(3003);
				array[num].SetDefaults(40);
				array[num].SetDefaults(3310);
				array[num].SetDefaults(3313);
				array[num].SetDefaults(3312);
				array[num].SetDefaults(3311);
				array[num].SetDefaults(166);
				array[num].SetDefaults(965);
				array[num].SetDefaults(3316);
				array[num].SetDefaults(3315);
				array[num].SetDefaults(3334);
				array[num].SetDefaults(3258);
				array[num].SetDefaults(3043);
			}
			else if (type == 21)
			{
				bool flag2 = Main.hardMode && NPC.downedMechBossAny;
				object obj = Main.hardMode && NPC.downedGolemBoss;
				array[num].SetDefaults(353);
				num++;
				array[num].SetDefaults(3828);
				if (obj != null)
				{
					array[num].shopCustomPrice = new int?(Item.buyPrice(0, 4, 0, 0));
				}
				else if (flag2)
				{
					array[num].shopCustomPrice = new int?(Item.buyPrice(0, 1, 0, 0));
				}
				else
				{
					array[num].shopCustomPrice = new int?(Item.buyPrice(0, 0, 25, 0));
				}
				num++;
				array[num].SetDefaults(3816);
				num++;
				array[num].SetDefaults(3813);
				array[num].shopCustomPrice = new int?(75);
				array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
				num++;
				num = 10;
				array[num].SetDefaults(3818);
				array[num].shopCustomPrice = new int?(5);
				array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
				num++;
				array[num].SetDefaults(3824);
				array[num].shopCustomPrice = new int?(5);
				array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
				num++;
				array[num].SetDefaults(3832);
				array[num].shopCustomPrice = new int?(5);
				array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
				num++;
				array[num].SetDefaults(3829);
				array[num].shopCustomPrice = new int?(5);
				array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
				if (flag2)
				{
					num = 20;
					array[num].SetDefaults(3819);
					array[num].shopCustomPrice = new int?(25);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3825);
					array[num].shopCustomPrice = new int?(25);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3833);
					array[num].shopCustomPrice = new int?(25);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3830);
					array[num].shopCustomPrice = new int?(25);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
				}
				if (obj != null)
				{
					num = 30;
					array[num].SetDefaults(3820);
					array[num].shopCustomPrice = new int?(100);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3826);
					array[num].shopCustomPrice = new int?(100);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3834);
					array[num].shopCustomPrice = new int?(100);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3831);
					array[num].shopCustomPrice = new int?(100);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
				}
				if (flag2)
				{
					num = 4;
					array[num].SetDefaults(3800);
					array[num].shopCustomPrice = new int?(25);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3801);
					array[num].shopCustomPrice = new int?(25);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3802);
					array[num].shopCustomPrice = new int?(25);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					num = 14;
					array[num].SetDefaults(3797);
					array[num].shopCustomPrice = new int?(25);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3798);
					array[num].shopCustomPrice = new int?(25);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3799);
					array[num].shopCustomPrice = new int?(25);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					num = 24;
					array[num].SetDefaults(3803);
					array[num].shopCustomPrice = new int?(25);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3804);
					array[num].shopCustomPrice = new int?(25);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3805);
					array[num].shopCustomPrice = new int?(25);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					num = 34;
					array[num].SetDefaults(3806);
					array[num].shopCustomPrice = new int?(25);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3807);
					array[num].shopCustomPrice = new int?(25);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3808);
					array[num].shopCustomPrice = new int?(25);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
				}
				if (obj != null)
				{
					num = 7;
					array[num].SetDefaults(3871);
					array[num].shopCustomPrice = new int?(75);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3872);
					array[num].shopCustomPrice = new int?(75);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3873);
					array[num].shopCustomPrice = new int?(75);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					num = 17;
					array[num].SetDefaults(3874);
					array[num].shopCustomPrice = new int?(75);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3875);
					array[num].shopCustomPrice = new int?(75);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3876);
					array[num].shopCustomPrice = new int?(75);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					num = 27;
					array[num].SetDefaults(3877);
					array[num].shopCustomPrice = new int?(75);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3878);
					array[num].shopCustomPrice = new int?(75);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3879);
					array[num].shopCustomPrice = new int?(75);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					num = 37;
					array[num].SetDefaults(3880);
					array[num].shopCustomPrice = new int?(75);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3881);
					array[num].shopCustomPrice = new int?(75);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
					array[num].SetDefaults(3882);
					array[num].shopCustomPrice = new int?(75);
					array[num].shopSpecialCurrency = CustomCurrencyID.DefenderMedals;
					num++;
				}
				if (obj != null)
				{
					num = 39;
				}
				else if (flag2)
				{
					num = 30;
				}
				else
				{
					num = 4;
				}
			}
			else if (type == 22)
			{
				array[num++].SetDefaults(4587);
				array[num++].SetDefaults(4590);
				array[num++].SetDefaults(4589);
				array[num++].SetDefaults(4588);
				array[num++].SetDefaults(4083);
				array[num++].SetDefaults(4084);
				array[num++].SetDefaults(4085);
				array[num++].SetDefaults(4086);
				array[num++].SetDefaults(4087);
				array[num++].SetDefaults(4088);
				int golferScoreAccumulated = Main.LocalPlayer.golferScoreAccumulated;
				if (golferScoreAccumulated > 500)
				{
					array[num].SetDefaults(4039);
					num++;
					array[num].SetDefaults(4094);
					num++;
					array[num].SetDefaults(4093);
					num++;
					array[num].SetDefaults(4092);
					num++;
				}
				array[num++].SetDefaults(4089);
				array[num++].SetDefaults(3989);
				array[num++].SetDefaults(4095);
				array[num++].SetDefaults(4040);
				array[num++].SetDefaults(4319);
				array[num++].SetDefaults(4320);
				if (golferScoreAccumulated > 1000)
				{
					array[num].SetDefaults(4591);
					num++;
					array[num].SetDefaults(4594);
					num++;
					array[num].SetDefaults(4593);
					num++;
					array[num].SetDefaults(4592);
					num++;
				}
				array[num++].SetDefaults(4135);
				array[num++].SetDefaults(4138);
				array[num++].SetDefaults(4136);
				array[num++].SetDefaults(4137);
				array[num++].SetDefaults(4049);
				if (golferScoreAccumulated > 500)
				{
					array[num].SetDefaults(4265);
					num++;
				}
				if (golferScoreAccumulated > 2000)
				{
					array[num].SetDefaults(4595);
					num++;
					array[num].SetDefaults(4598);
					num++;
					array[num].SetDefaults(4597);
					num++;
					array[num].SetDefaults(4596);
					num++;
					if (NPC.downedBoss3)
					{
						array[num].SetDefaults(4264);
						num++;
					}
				}
				if (golferScoreAccumulated > 500)
				{
					array[num].SetDefaults(4599);
					num++;
				}
				if (golferScoreAccumulated >= 1000)
				{
					array[num].SetDefaults(4600);
					num++;
				}
				if (golferScoreAccumulated >= 2000)
				{
					array[num].SetDefaults(4601);
					num++;
				}
				if (golferScoreAccumulated >= 2000)
				{
					if (Main.moonPhase == 0 || Main.moonPhase == 1)
					{
						array[num].SetDefaults(4658);
						num++;
					}
					else if (Main.moonPhase == 2 || Main.moonPhase == 3)
					{
						array[num].SetDefaults(4659);
						num++;
					}
					else if (Main.moonPhase == 4 || Main.moonPhase == 5)
					{
						array[num].SetDefaults(4660);
						num++;
					}
					else if (Main.moonPhase == 6 || Main.moonPhase == 7)
					{
						array[num].SetDefaults(4661);
						num++;
					}
				}
			}
			else if (type == 23)
			{
				BestiaryUnlockProgressReport bestiaryProgressReport = Main.GetBestiaryProgressReport();
				if (Chest.BestiaryGirl_IsFairyTorchAvailable())
				{
					array[num++].SetDefaults(4776);
				}
				array[num++].SetDefaults(4767);
				array[num++].SetDefaults(4759);
				if (bestiaryProgressReport.CompletionPercent >= 0.15f)
				{
					array[num++].SetDefaults(4672);
				}
				if (!NPC.boughtCat)
				{
					array[num++].SetDefaults(4829);
				}
				if (!NPC.boughtDog && bestiaryProgressReport.CompletionPercent >= 0.25f)
				{
					array[num++].SetDefaults(4830);
				}
				if (!NPC.boughtBunny && bestiaryProgressReport.CompletionPercent >= 0.45f)
				{
					array[num++].SetDefaults(4910);
				}
				if (bestiaryProgressReport.CompletionPercent >= 0.3f)
				{
					array[num++].SetDefaults(4871);
				}
				if (bestiaryProgressReport.CompletionPercent >= 0.3f)
				{
					array[num++].SetDefaults(4907);
				}
				if (NPC.downedTowerSolar)
				{
					array[num++].SetDefaults(4677);
				}
				if (bestiaryProgressReport.CompletionPercent >= 0.1f)
				{
					array[num++].SetDefaults(4676);
				}
				if (bestiaryProgressReport.CompletionPercent >= 0.3f)
				{
					array[num++].SetDefaults(4762);
				}
				if (bestiaryProgressReport.CompletionPercent >= 0.25f)
				{
					array[num++].SetDefaults(4716);
				}
				if (bestiaryProgressReport.CompletionPercent >= 0.3f)
				{
					array[num++].SetDefaults(4785);
				}
				if (bestiaryProgressReport.CompletionPercent >= 0.3f)
				{
					array[num++].SetDefaults(4786);
				}
				if (bestiaryProgressReport.CompletionPercent >= 0.3f)
				{
					array[num++].SetDefaults(4787);
				}
				if (bestiaryProgressReport.CompletionPercent >= 0.3f && Main.hardMode)
				{
					array[num++].SetDefaults(4788);
				}
				if (bestiaryProgressReport.CompletionPercent >= 0.4f)
				{
					array[num++].SetDefaults(4955);
				}
				if (Main.hardMode && Main.bloodMoon)
				{
					array[num++].SetDefaults(4736);
				}
				if (NPC.downedPlantBoss)
				{
					array[num++].SetDefaults(4701);
				}
				if (bestiaryProgressReport.CompletionPercent >= 0.5f)
				{
					array[num++].SetDefaults(4765);
				}
				if (bestiaryProgressReport.CompletionPercent >= 0.5f)
				{
					array[num++].SetDefaults(4766);
				}
				if (bestiaryProgressReport.CompletionPercent >= 0.5f)
				{
					array[num++].SetDefaults(4777);
				}
				if (bestiaryProgressReport.CompletionPercent >= 0.6f)
				{
					array[num++].SetDefaults(4763);
				}
				if (bestiaryProgressReport.CompletionPercent >= 0.7f)
				{
					array[num++].SetDefaults(4735);
				}
				if (bestiaryProgressReport.CompletionPercent >= 1f)
				{
					array[num++].SetDefaults(4951);
				}
				switch (Main.moonPhase)
				{
				case 0:
				case 1:
					array[num++].SetDefaults(4768);
					array[num++].SetDefaults(4769);
					break;
				case 2:
				case 3:
					array[num++].SetDefaults(4770);
					array[num++].SetDefaults(4771);
					break;
				case 4:
				case 5:
					array[num++].SetDefaults(4772);
					array[num++].SetDefaults(4773);
					break;
				case 6:
				case 7:
					array[num++].SetDefaults(4560);
					array[num++].SetDefaults(4775);
					break;
				}
			}
			if (type != 19 && type != 20 && flag && !Main.player[Main.myPlayer].ZoneCorrupt && !Main.player[Main.myPlayer].ZoneCrimson)
			{
				if (!Main.player[Main.myPlayer].ZoneSnow && !Main.player[Main.myPlayer].ZoneDesert && !Main.player[Main.myPlayer].ZoneBeach && !Main.player[Main.myPlayer].ZoneJungle && !Main.player[Main.myPlayer].ZoneHallow && !Main.player[Main.myPlayer].ZoneGlowshroom && (double)(Main.player[Main.myPlayer].Center.Y / 16f) < Main.worldSurface && num < 39)
				{
					array[num++].SetDefaults(4876);
				}
				if (Main.player[Main.myPlayer].ZoneSnow && num < 39)
				{
					array[num++].SetDefaults(4920);
				}
				if (Main.player[Main.myPlayer].ZoneDesert && num < 39)
				{
					array[num++].SetDefaults(4919);
				}
				if (!Main.player[Main.myPlayer].ZoneSnow && !Main.player[Main.myPlayer].ZoneDesert && !Main.player[Main.myPlayer].ZoneBeach && !Main.player[Main.myPlayer].ZoneJungle && !Main.player[Main.myPlayer].ZoneHallow && !Main.player[Main.myPlayer].ZoneGlowshroom && (double)(Main.player[Main.myPlayer].Center.Y / 16f) >= Main.worldSurface && num < 39)
				{
					array[num++].SetDefaults(4917);
				}
				if (Main.player[Main.myPlayer].ZoneBeach && (double)Main.player[Main.myPlayer].position.Y < Main.worldSurface * 16.0 && num < 39)
				{
					array[num++].SetDefaults(4918);
				}
				if (Main.player[Main.myPlayer].ZoneJungle && num < 39)
				{
					array[num++].SetDefaults(4875);
				}
				if (Main.player[Main.myPlayer].ZoneHallow && num < 39)
				{
					array[num++].SetDefaults(4916);
				}
				if (Main.player[Main.myPlayer].ZoneGlowshroom && num < 39)
				{
					array[num++].SetDefaults(4921);
				}
			}
			else if (type == 24)
			{
				array[num++].SetDefaults(5071);
				array[num++].SetDefaults(5072);
				array[num++].SetDefaults(5073);
				array[num++].SetDefaults(5076);
				array[num++].SetDefaults(5077);
				array[num++].SetDefaults(5078);
				array[num++].SetDefaults(5079);
				array[num++].SetDefaults(5080);
				array[num++].SetDefaults(5081);
				array[num++].SetDefaults(5082);
				array[num++].SetDefaults(5083);
				array[num++].SetDefaults(5084);
				array[num++].SetDefaults(5085);
				array[num++].SetDefaults(5086);
				array[num++].SetDefaults(5087);
				array[num++].SetDefaults(5044);
			}
			if (type != 19 && type != 20 && flag && !Main.player[Main.myPlayer].ZoneCorrupt && !Main.player[Main.myPlayer].ZoneCrimson)
			{
				if (!Main.player[Main.myPlayer].ZoneSnow && !Main.player[Main.myPlayer].ZoneDesert && !Main.player[Main.myPlayer].ZoneBeach && !Main.player[Main.myPlayer].ZoneJungle && !Main.player[Main.myPlayer].ZoneHallow && !Main.player[Main.myPlayer].ZoneGlowshroom && (double)(Main.player[Main.myPlayer].Center.Y / 16f) < Main.worldSurface && num < 39)
				{
					array[num++].SetDefaults(4876);
				}
				if (Main.player[Main.myPlayer].ZoneSnow && num < 39)
				{
					array[num++].SetDefaults(4920);
				}
				if (Main.player[Main.myPlayer].ZoneDesert && num < 39)
				{
					array[num++].SetDefaults(4919);
				}
				if (!Main.player[Main.myPlayer].ZoneSnow && !Main.player[Main.myPlayer].ZoneDesert && !Main.player[Main.myPlayer].ZoneBeach && !Main.player[Main.myPlayer].ZoneJungle && !Main.player[Main.myPlayer].ZoneHallow && !Main.player[Main.myPlayer].ZoneGlowshroom && (double)(Main.player[Main.myPlayer].Center.Y / 16f) >= Main.worldSurface && num < 39)
				{
					array[num++].SetDefaults(4917);
				}
				if (Main.player[Main.myPlayer].ZoneBeach && (double)Main.player[Main.myPlayer].position.Y < Main.worldSurface * 16.0 && num < 39)
				{
					array[num++].SetDefaults(4918);
				}
				if (Main.player[Main.myPlayer].ZoneJungle && num < 39)
				{
					array[num++].SetDefaults(4875);
				}
				if (Main.player[Main.myPlayer].ZoneHallow && num < 39)
				{
					array[num++].SetDefaults(4916);
				}
				if (Main.player[Main.myPlayer].ZoneGlowshroom && num < 39)
				{
					array[num++].SetDefaults(4921);
				}
			}
			for (int num3 = 0; num3 < num; num3++)
			{
				array[num3].isAShopItem = true;
			}
		}
	}
}
