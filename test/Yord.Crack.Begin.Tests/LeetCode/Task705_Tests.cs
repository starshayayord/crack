using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task705_Tests
    {
        [Test]
        public void Should_UseMyHashSet_BST()
        {
            var t = new Task705.MyHashSet_BST();
            Assert.IsFalse(t.Contains(88));
            t.Remove(130);
            Assert.IsFalse(t.Contains(3));
            t.Add(952);
            t.Remove(767);
            t.Add(206);
            Assert.IsFalse(t.Contains(268));
            t.Add(658);
            t.Add(918);
            t.Add(709);
            t.Remove(965);
            Assert.IsFalse(t.Contains(558));
            t.Remove(645);
            t.Add(667);
            Assert.IsTrue(t.Contains(206));
            t.Remove(404);
            Assert.IsTrue(t.Contains(918));
            t.Remove(139);
            t.Remove(686);
            Assert.IsFalse(t.Contains(71));
            t.Add(453);
            Assert.IsTrue(t.Contains(918));
            Assert.IsFalse(t.Contains(321));
            t.Remove(597);
            t.Remove(923);
            t.Remove(296);
            t.Add(213);
            t.Add(203);
            t.Add(521);
            Assert.IsTrue(t.Contains(213));
            t.Remove(55);
            Assert.IsFalse(t.Contains(418));
            t.Remove(920);
            t.Add(616);
            t.Add(676);
            t.Add(825);
            Assert.IsTrue(t.Contains(667));
            t.Add(304);
            t.Add(782);
            t.Add(3);
            t.Add(422);
            t.Add(131);
            Assert.IsFalse(t.Contains(114));
            t.Add(641);
            t.Add(9);
            t.Remove(992);
            t.Add(347);
            t.Add(850);
            t.Add(930);
            Assert.IsTrue(t.Contains(304));
            t.Add(184);
            t.Add(58);
            t.Add(183);
            t.Add(198);
            t.Add(491);
            t.Add(322);
            t.Remove(295);
            t.Remove(484);
            t.Add(97);
            t.Add(298);
            t.Add(362);
            t.Add(210);
            t.Add(329);
            t.Add(177);
            t.Remove(546);
            Assert.IsTrue(t.Contains(3));
            t.Add(468);
            Assert.IsFalse(t.Contains(724));
            t.Remove(41);
            t.Remove(804);
            t.Remove(959);
            t.Add(339);
            t.Add(258);
            Assert.IsTrue(t.Contains(453));
            t.Add(618);
            t.Remove(94);
            t.Add(834);
            Assert.IsTrue(t.Contains(97));
            t.Remove(317);
            t.Add(589);
            Assert.IsFalse(t.Contains(357));
            t.Remove(430);
            Assert.IsFalse(t.Contains(571));
            t.Add(477);
            t.Add(486);
            Assert.IsTrue(t.Contains(203));
            Assert.IsTrue(t.Contains(491));
            t.Add(626);
            t.Add(924);
            t.Add(267);
            Assert.IsFalse(t.Contains(846));
            t.Remove(333);
            t.Add(794);
            t.Add(238);
            t.Remove(406);
            t.Remove(397);
            t.Remove(120);
            t.Remove(939);
            t.Add(30);
            t.Add(452);
            t.Add(865);
            Assert.IsTrue(t.Contains(422));
            t.Add(825);
            t.Add(246);
            t.Add(364);
            t.Add(17);
            t.Add(558);
            Assert.IsTrue(t.Contains(183));
            t.Add(966);
            t.Add(935);
            t.Remove(765);
            t.Remove(741);
            t.Add(496);
            Assert.IsTrue(t.Contains(422));
            t.Add(33);
            t.Add(66);
            t.Add(490);
            t.Add(629);
            t.Add(693);
            Assert.IsFalse(t.Contains(697));
            t.Add(155);
            t.Remove(29);
            t.Add(683);
            t.Remove(667);
            t.Add(106);
            Assert.IsTrue(t.Contains(66));
            Assert.IsTrue(t.Contains(258));
            t.Remove(134);
            t.Add(417);
            t.Add(97);
            t.Add(57);
            t.Remove(790);
            Assert.IsFalse(t.Contains(86));
            t.Add(69);
            t.Add(966);
            Assert.IsTrue(t.Contains(364));
            t.Add(824);
            Assert.IsTrue(t.Contains(258));
            t.Add(596);
            Assert.IsTrue(t.Contains(422));
            t.Remove(873);
            t.Add(25);
            Assert.IsFalse(t.Contains(386));
            t.Add(334);
            t.Add(700);
            t.Add(794);
            t.Add(773);
            t.Add(203);
            t.Add(106);
            t.Remove(861);
            t.Add(433);
            t.Add(253);
            t.Remove(130);
            Assert.IsTrue(t.Contains(616));
            t.Add(6);
            t.Remove(535);
            t.Remove(215);
            t.Add(770);
            Assert.IsTrue(t.Contains(258));
            t.Add(947);
            t.Add(117);
            t.Add(633);
            t.Remove(708);
            t.Add(117);
            t.Add(191);
            t.Add(490);
            t.Add(36);
            Assert.IsTrue(t.Contains(117));
            Assert.IsTrue(t.Contains(210));
            t.Add(522);
            t.Add(630);
            t.Add(951);
            t.Add(772);
            t.Add(831);
            Assert.IsTrue(t.Contains(25));
            Assert.IsFalse(t.Contains(988));
            t.Remove(648);
            t.Add(980);
            t.Add(440);
            t.Remove(729);
            t.Remove(351);
            Assert.IsFalse(t.Contains(273));
            Assert.IsTrue(t.Contains(596));
            t.Add(770);
            t.Add(645);
            t.Add(320);
            t.Add(344);
            t.Add(57);
            t.Add(814);
            t.Add(985);
            t.Add(449);
            t.Add(475);
            Assert.IsTrue(t.Contains(17));
            t.Add(317);
            t.Remove(390);
            t.Add(896);
            t.Remove(779);
            Assert.IsTrue(t.Contains(770));
            t.Remove(724);
            t.Remove(496);
            t.Remove(751);
            Assert.IsFalse(t.Contains(91));
            t.Remove(432);
            t.Add(557);
            Assert.IsFalse(t.Contains(98));
            t.Add(22);
            t.Add(635);
            t.Add(774);
            t.Remove(203);
            t.Add(876);
            Assert.IsTrue(t.Contains(57));
            Assert.IsTrue(t.Contains(106));
            Assert.IsFalse(t.Contains(544));
            t.Remove(153);
            t.Add(618);
            Assert.IsTrue(t.Contains(433));
            t.Remove(614);
            t.Add(166);
            t.Add(724);
            t.Add(910);
            Assert.IsTrue(t.Contains(834));
            t.Add(42);
            t.Add(369);
            t.Add(348);
            t.Add(668);
            t.Add(450);
            t.Remove(473);
            t.Add(390);
            t.Add(278);
            t.Remove(993);
            t.Add(705);
            t.Remove(673);
            t.Remove(518);
            t.Add(927);
            t.Add(859);
            t.Add(447);
            Assert.IsFalse(t.Contains(563));
            t.Add(971);
            Assert.IsFalse(t.Contains(443));
            t.Remove(611);
            Assert.IsTrue(t.Contains(69));
            Assert.IsTrue(t.Contains(831));
            t.Add(611);
            t.Add(4);
            t.Add(723);
            t.Add(230);
            Assert.IsTrue(t.Contains(814));
            t.Add(786);
            t.Add(75);
            t.Add(568);
            t.Add(223);
            Assert.IsFalse(t.Contains(533));
            t.Add(311);
            t.Add(163);
            t.Add(822);
            Assert.IsFalse(t.Contains(714));
            t.Add(789);
            t.Remove(566);
            t.Add(741);
            t.Add(594);
            t.Add(646);
            t.Add(460);
            Assert.IsTrue(t.Contains(709));
            t.Remove(805);
            Assert.IsTrue(t.Contains(317));
            t.Add(617);
            t.Remove(504);
            t.Add(39);
            t.Add(808);
            t.Add(190);
            t.Add(888);
            t.Add(709);
            t.Add(388);
            t.Remove(607);
            t.Remove(689);
            t.Remove(237);
            t.Remove(764);
            t.Add(445);
            t.Remove(661);
            t.Remove(677);
            t.Remove(280);
            t.Add(935);
            t.Add(154);
            t.Add(165);
            t.Add(806);
            t.Add(791);
            t.Add(20);
            Assert.IsFalse(t.Contains(667));
            t.Add(796);
            t.Remove(184);
            t.Add(731);
            t.Add(286);
            Assert.IsFalse(t.Contains(203));
            t.Add(975);
            t.Add(499);
            t.Add(97);
            t.Add(184);
            t.Add(934);
            t.Add(698);
            Assert.IsFalse(t.Contains(743));
            t.Add(43);
            t.Add(613);
            t.Add(174);
            Assert.IsTrue(t.Contains(258));
            t.Add(853);
            t.Remove(278);
            t.Add(558);
            t.Add(520);
            Assert.IsFalse(t.Contains(185));
            Assert.IsTrue(t.Contains(521));
            t.Add(652);
            t.Add(0);
            t.Remove(941);
            t.Add(617);
            t.Remove(671);
            Assert.IsTrue(t.Contains(831));
            t.Add(701);
            Assert.IsTrue(t.Contains(741));
            t.Add(962);
            t.Add(848);
            t.Add(756);
            t.Remove(653);
            t.Add(121);
            t.Add(696);
            Assert.IsFalse(t.Contains(38));
            Assert.IsTrue(t.Contains(853));
            t.Add(974);
            t.Remove(461);
            Assert.IsTrue(t.Contains(794));
            t.Add(380);
            Assert.IsTrue(t.Contains(9));
            t.Add(763);
            t.Remove(746);
            Assert.IsTrue(t.Contains(246));
            t.Add(747);
            t.Add(15);
            Assert.IsTrue(t.Contains(934));
            t.Add(593);
            t.Add(498);
            Assert.IsTrue(t.Contains(825));
            Assert.IsTrue(t.Contains(558));
            Assert.IsFalse(t.Contains(196));
            t.Remove(309);
            t.Add(146);
            Assert.IsTrue(t.Contains(166));
            t.Add(39);
            t.Remove(909);
            t.Add(797);
            t.Add(749);
            Assert.IsTrue(t.Contains(824));
            t.Add(891);
            Assert.IsTrue(t.Contains(43));
            t.Add(79);
            t.Add(798);
            t.Add(481);
            t.Add(611);
            t.Add(206);
            Assert.IsFalse(t.Contains(148));
            t.Remove(370);
            t.Add(96);
            t.Remove(742);
            t.Add(463);
            Assert.IsTrue(t.Contains(723));
            Assert.IsTrue(t.Contains(641));
            t.Add(179);
            t.Add(497);
            t.Add(770);
            t.Add(987);
            t.Add(391);
            Assert.IsTrue(t.Contains(749));
            t.Remove(566);
            t.Add(603);
            t.Add(779);
            t.Add(483);
            t.Add(836);
            Assert.IsTrue(t.Contains(499));
            t.Remove(107);
            t.Remove(451);
            t.Remove(998);
            t.Add(668);
            Assert.IsTrue(t.Contains(974));
            t.Remove(317);
            t.Remove(976);
            Assert.IsFalse(t.Contains(673));
            t.Remove(320);
            Assert.IsTrue(t.Contains(772));
            t.Remove(623);
            t.Add(64);
            Assert.IsFalse(t.Contains(454));
            t.Remove(714);
            t.Add(224);
            Assert.IsTrue(t.Contains(6));
            t.Remove(51);
            t.Add(634);
            t.Remove(249);
            t.Add(460);
            t.Add(725);
            t.Add(980);
            t.Add(578);
            t.Remove(712);
            t.Add(380);
            t.Add(319);
            t.Add(225);
            t.Add(782);
            t.Add(927);
            t.Add(255);
            Assert.IsTrue(t.Contains(927));
            t.Remove(28);
            Assert.IsFalse(t.Contains(149));
            t.Add(454);
            t.Add(948);
            Assert.IsFalse(t.Contains(875));
            t.Remove(566);
            t.Add(978);
            t.Remove(451);
            Assert.IsFalse(t.Contains(70));
            t.Add(511);
            Assert.IsTrue(t.Contains(258));
            t.Remove(516);
            t.Add(758);
            Assert.IsFalse(t.Contains(197));
            Assert.IsFalse(t.Contains(185));
            Assert.IsFalse(t.Contains(524));
            t.Add(243);
            Assert.IsFalse(t.Contains(367));
            Assert.IsFalse(t.Contains(976));
            Assert.IsFalse(t.Contains(441));
            t.Add(942);
            t.Remove(629);
            t.Add(942);
            t.Add(936);
            t.Remove(325);
            t.Add(949);
            t.Remove(999);
            t.Add(399);
            Assert.IsTrue(t.Contains(286));
            Assert.IsTrue(t.Contains(155));
            t.Add(992);
            t.Add(766);
            t.Remove(884);
            t.Add(793);
            t.Add(328);
            t.Remove(855);
            Assert.IsFalse(t.Contains(493));
            t.Add(400);
            t.Add(771);
            t.Add(739);
            t.Remove(157);
            Assert.IsTrue(t.Contains(646));
            Assert.IsTrue(t.Contains(166));
            t.Remove(648);
            t.Add(566);
            t.Remove(395);
            Assert.IsTrue(t.Contains(42));
            t.Add(524);
            t.Add(597);
            t.Add(909);
            t.Add(492);
            Assert.IsTrue(t.Contains(658));
            t.Add(932);
            Assert.IsFalse(t.Contains(496));
            Assert.IsTrue(t.Contains(369));
            Assert.IsTrue(t.Contains(822));
            t.Add(930);
            t.Add(66);
            t.Add(655);
            t.Remove(340);
            t.Add(866);
            t.Add(571);
            t.Add(929);
            Assert.IsFalse(t.Contains(340));
            t.Add(577);
            t.Add(788);
            Assert.IsTrue(t.Contains(319));
            Assert.IsFalse(t.Contains(563));
            t.Add(675);
            t.Add(320);
            t.Add(521);
            t.Add(538);
            t.Remove(40);
            t.Add(515);
            t.Add(556);
            t.Remove(979);
            Assert.IsFalse(t.Contains(894));
            t.Add(20);
            t.Add(389);
            t.Remove(286);
            t.Add(814);
            t.Add(170);
            t.Add(555);
            Assert.IsFalse(t.Contains(169));
            Assert.IsFalse(t.Contains(32));
            Assert.IsTrue(t.Contains(593));
            t.Add(476);
            t.Add(113);
            t.Add(535);
            t.Add(423);
            t.Add(29);
            t.Add(413);
            t.Remove(171);
            t.Add(780);
            t.Add(73);
            t.Remove(177);
            t.Add(866);
            t.Add(951);
            Assert.IsFalse(t.Contains(268));
            t.Add(562);
            t.Remove(720);
            t.Add(260);
            t.Remove(691);
            t.Remove(793);
            t.Remove(834);
            t.Remove(948);
            t.Remove(60);
            Assert.IsFalse(t.Contains(98));
            t.Add(516);
            t.Remove(864);
            t.Add(624);
            t.Remove(162);
            t.Remove(156);
            t.Add(237);
            Assert.IsFalse(t.Contains(234));
            t.Add(832);
            t.Add(871);
            t.Add(606);
            t.Add(840);
            Assert.IsTrue(t.Contains(498));
            Assert.IsTrue(t.Contains(191));
            t.Add(55);
            t.Add(14);
            t.Add(815);
            t.Add(590);
            t.Add(17);
            Assert.IsTrue(t.Contains(225));
            t.Add(974);
            t.Add(883);
            t.Remove(280);
            t.Add(490);
            t.Remove(736);
            t.Add(851);
            Assert.IsTrue(t.Contains(4));
            t.Add(857);
            t.Add(92);
            t.Remove(105);
            t.Add(400);
            t.Add(63);
            t.Add(781);
            t.Add(192);
            t.Add(437);
            t.Add(300);
            t.Add(3);
            t.Remove(271);
            t.Add(270);
            Assert.IsTrue(t.Contains(460));
            t.Add(677);
            t.Remove(272);
            Assert.IsTrue(t.Contains(511));
            t.Add(885);
            t.Remove(200);
            t.Add(560);
            t.Add(911);
            t.Add(47);
            t.Add(105);
            t.Remove(445);
            t.Add(306);
            t.Add(94);
            t.Remove(654);
            t.Add(663);
            t.Add(32);
            t.Remove(624);
            t.Add(536);
            t.Remove(584);
            Assert.IsFalse(t.Contains(469));
            t.Add(840);
            t.Add(675);
            Assert.IsFalse(t.Contains(200));
            t.Add(805);
            t.Remove(848);
            t.Add(453);
            t.Add(771);
            t.Add(713);
            t.Remove(81);
            t.Remove(465);
            t.Remove(156);
            t.Add(396);
            Assert.IsFalse(t.Contains(554));
            t.Remove(144);
            t.Add(406);
            t.Add(152);
            t.Add(110);
            t.Add(752);
            t.Add(419);
            t.Add(440);
            t.Remove(669);
            t.Remove(950);
            t.Remove(691);
            t.Remove(534);
            t.Add(37);
            t.Add(128);
            t.Add(859);
            t.Add(625);
            t.Add(527);
            t.Add(152);
            t.Remove(230);
            t.Add(333);
            t.Add(836);
            t.Add(473);
            t.Add(322);
            t.Add(654);
            t.Add(329);
            t.Add(213);
            t.Add(462);
            t.Add(722);
            Assert.IsFalse(t.Contains(404));
            Assert.IsTrue(t.Contains(652));
            t.Add(821);
            t.Remove(573);
            t.Add(839);
            t.Add(637);
            t.Add(495);
            t.Add(678);
            t.Remove(161);
            t.Add(105);
            t.Remove(567);
            t.Remove(731);
            Assert.IsTrue(t.Contains(683));
            t.Add(711);
            Assert.IsFalse(t.Contains(908));
            t.Add(458);
            t.Add(501);
            t.Add(657);
            t.Remove(491);
            t.Add(565);
            Assert.IsTrue(t.Contains(328));
            t.Add(356);
            t.Add(374);
            t.Add(532);
            t.Add(739);
            t.Remove(869);
            t.Add(811);
            Assert.IsTrue(t.Contains(596));
            t.Remove(155);
            t.Add(412);
            t.Remove(217);
            t.Add(539);
            t.Add(618);
            t.Add(782);
            t.Add(942);
            Assert.IsFalse(t.Contains(286));
            Assert.IsFalse(t.Contains(542));
            Assert.IsTrue(t.Contains(936));
            t.Add(519);
            t.Add(67);
            t.Remove(4);
            t.Add(614);
            t.Remove(925);
            t.Remove(379);
            t.Add(883);
            t.Add(570);
            Assert.IsFalse(t.Contains(278));
            Assert.IsTrue(t.Contains(971));
            t.Add(388);
            t.Remove(43);
            Assert.IsFalse(t.Contains(72));
            t.Add(206);
            t.Add(529);
            t.Add(738);
            t.Remove(248);
            Assert.IsFalse(t.Contains(112));
            t.Add(919);
            t.Remove(585);
            t.Add(30);
            t.Add(338);
            Assert.IsFalse(t.Contains(826));
            t.Add(154);
            t.Remove(864);
            t.Add(381);
            t.Remove(787);
            t.Add(488);
            t.Add(533);
            t.Add(116);
            t.Add(10);
            t.Add(77);
            Assert.IsFalse(t.Contains(119));
            t.Add(720);
            t.Remove(275);
            t.Remove(59);
            t.Add(657);
            t.Add(70);
            t.Remove(398);
            t.Add(749);
            t.Add(988);
            t.Add(5);
            Assert.IsTrue(t.Contains(304));
            t.Remove(390);
            t.Add(807);
            t.Add(166);
            t.Remove(441);
            t.Add(924);
            t.Add(355);
            t.Add(821);
            t.Add(648);
            t.Add(168);
            Assert.IsTrue(t.Contains(433));
            t.Add(573);
            Assert.IsTrue(t.Contains(300));
            t.Remove(678);
            t.Add(741);
            t.Add(386);
            t.Remove(808);
            t.Add(172);
            t.Add(343);
            t.Add(202);
            t.Remove(8);
            t.Add(663);
            t.Add(150);
            t.Add(816);
            t.Remove(611);
            t.Add(907);
            t.Add(432);
            t.Remove(988);
            Assert.IsTrue(t.Contains(630));
            t.Remove(694);
            Assert.IsTrue(t.Contains(22));
            t.Remove(32);
            t.Add(115);
            t.Add(300);
            t.Add(926);
            t.Add(852);
            t.Add(925);
            Assert.IsTrue(t.Contains(92));
            Assert.IsFalse(t.Contains(175));
            t.Add(619);
            t.Add(471);
            t.Remove(357);
            t.Add(300);
            t.Remove(572);
            Assert.IsFalse(t.Contains(954));
            t.Remove(612);
            t.Add(998);
            t.Remove(133);
            t.Add(351);
            t.Add(279);
            t.Add(234);
            t.Add(632);
            t.Add(936);
            Assert.IsTrue(t.Contains(947));
            Assert.IsTrue(t.Contains(524));
            t.Add(277);
            t.Add(757);
            t.Add(856);
            t.Add(916);
            Assert.IsTrue(t.Contains(57));
            t.Add(187);
            Assert.IsTrue(t.Contains(757));
            t.Add(495);
            t.Add(854);
            t.Add(808);
            t.Remove(515);
            t.Remove(551);
            Assert.IsFalse(t.Contains(464));
            t.Remove(795);
            t.Add(454);
            t.Remove(860);
            t.Add(424);
            t.Add(692);
            Assert.IsTrue(t.Contains(633));
            t.Remove(998);
            t.Remove(184);
            t.Remove(710);
            t.Remove(41);
            t.Remove(753);
            Assert.IsTrue(t.Contains(535));
            Assert.IsTrue(t.Contains(558));
            t.Add(613);
            Assert.IsFalse(t.Contains(390));
            t.Add(697);
            Assert.IsTrue(t.Contains(460));
            t.Add(676);
            t.Add(905);
            t.Remove(533);
            t.Add(544);
            t.Add(848);
            t.Add(749);
            t.Add(703);
            t.Add(8);
            t.Add(803);
            t.Remove(149);
            t.Add(551);
            t.Add(816);
            Assert.IsTrue(t.Contains(3));
            t.Add(908);
            t.Remove(930);
            Assert.IsFalse(t.Contains(733));
            t.Remove(695);
            t.Add(781);
            t.Add(868);
            t.Add(165);
            t.Add(16);
            t.Remove(211);
            Assert.IsTrue(t.Contains(190));
            Assert.IsTrue(t.Contains(422));
            t.Add(363);
            Assert.IsFalse(t.Contains(684));
            Assert.IsFalse(t.Contains(994));
            t.Add(788);
            t.Add(146);
            Assert.IsTrue(t.Contains(789));
            t.Add(844);
            t.Remove(804);
            t.Remove(503);
            t.Add(167);
            t.Add(69);
            t.Add(771);
            Assert.IsFalse(t.Contains(323));
            t.Add(323);
            t.Add(953);
            t.Add(687);
            t.Add(304);
            t.Remove(458);
            t.Add(761);
            t.Add(378);
            Assert.IsTrue(t.Contains(486));
            Assert.IsTrue(t.Contains(654));
            Assert.IsTrue(t.Contains(386));
            t.Remove(364);
            t.Remove(555);
            t.Add(823);
            t.Add(560);
            t.Add(606);
            t.Add(167);
            t.Remove(781);
            t.Remove(624);
            t.Add(867);
            t.Remove(807);
            t.Add(243);
            Assert.IsFalse(t.Contains(721));
            t.Add(296);
            t.Add(517);
            t.Add(11);
            t.Add(52);
            Assert.IsFalse(t.Contains(203));
            t.Add(392);
            t.Add(519);
            Assert.IsFalse(t.Contains(764));
            Assert.IsTrue(t.Contains(306));
            t.Add(648);
            t.Add(390);
            t.Remove(606);
            t.Add(905);
            Assert.IsTrue(t.Contains(980));
            t.Add(54);
            t.Add(450);
            t.Add(905);
            t.Remove(535);
            t.Remove(590);
            t.Add(553);
            t.Add(600);
            t.Remove(586);
            Assert.IsTrue(t.Contains(648));
            Assert.IsFalse(t.Contains(205));
            t.Add(70);
            Assert.IsTrue(t.Contains(711));
            Assert.IsTrue(t.Contains(648));
            t.Remove(0);
            t.Remove(212);
            t.Remove(456);
            t.Add(636);
            t.Add(890);
            t.Remove(770);
            t.Remove(812);
            t.Remove(589);
            t.Add(463);
            Assert.IsTrue(t.Contains(154));
            Assert.IsFalse(t.Contains(451));
            t.Add(209);
            t.Add(243);
            Assert.IsFalse(t.Contains(715));
            t.Add(164);
            t.Add(698);
            t.Add(156);
            t.Add(996);
            t.Add(395);
            t.Add(905);
            Assert.IsTrue(t.Contains(66));
            t.Add(90);
            t.Add(98);
            t.Remove(482);
            Assert.IsFalse(t.Contains(416));
            t.Add(474);
            t.Add(637);
            t.Remove(197);
            t.Add(979);
            t.Add(494);
            Assert.IsTrue(t.Contains(789));
            Assert.IsTrue(t.Contains(831));
            t.Add(189);
            t.Add(205);
            t.Add(711);
            t.Add(340);
            t.Remove(63);
            t.Add(323);
            t.Add(372);
            t.Remove(570);
            t.Add(266);
            t.Add(848);
            t.Add(728);
            Assert.IsFalse(t.Contains(472));
            t.Add(764);
            t.Add(489);
            Assert.IsTrue(t.Contains(803));
            t.Add(814);
            t.Remove(533);
            t.Remove(257);
            t.Remove(569);
            t.Add(136);
            t.Remove(360);
            t.Add(264);
            Assert.IsTrue(t.Contains(522));
            t.Remove(919);
            t.Remove(701);
            t.Remove(707);
            Assert.IsTrue(t.Contains(924));
            t.Add(901);
            t.Add(276);
            t.Remove(870);
            t.Add(180);
            t.Add(534);
            Assert.IsTrue(t.Contains(916));
            t.Add(843);
            t.Add(183);
            Assert.IsTrue(t.Contains(432));
            t.Remove(550);
            t.Add(347);
            t.Add(211);
            t.Add(930);
            t.Add(858);
            Assert.IsTrue(t.Contains(851));
            t.Remove(577);
            t.Add(257);
            Assert.IsFalse(t.Contains(157));
            Assert.IsFalse(t.Contains(259));
            Assert.IsTrue(t.Contains(329));
            t.Add(915);
            Assert.IsTrue(t.Contains(253));
            Assert.IsTrue(t.Contains(96));
            t.Add(416);
            t.Add(883);
            t.Add(138);
            Assert.IsTrue(t.Contains(856));
            Assert.IsFalse(t.Contains(4));
            t.Add(109);
            t.Add(755);
            Assert.IsTrue(t.Contains(901));
            t.Add(487);
            t.Add(103);
            Assert.IsTrue(t.Contains(422));
            t.Remove(647);
            t.Remove(451);
            t.Remove(200);
            t.Remove(820);
            Assert.IsTrue(t.Contains(42));
            t.Add(616);
            t.Add(459);
            Assert.IsTrue(t.Contains(562));
            t.Add(954);
            t.Add(656);
            t.Add(950);
            t.Remove(141);
            t.Add(290);
            t.Add(407);
            t.Remove(808);
            t.Remove(58);
            t.Add(574);
            Assert.IsTrue(t.Contains(840));
            t.Add(622);
            Assert.IsTrue(t.Contains(832));
            t.Remove(857);
            t.Add(723);
            Assert.IsTrue(t.Contains(267));
            Assert.IsTrue(t.Contains(14));
            t.Add(215);
            t.Add(860);
            t.Add(862);
            t.Add(630);
            t.Add(133);
            Assert.IsTrue(t.Contains(724));
            t.Remove(595);
            t.Add(51);
            t.Remove(588);
            t.Add(180);
            t.Add(546);
            t.Add(842);
            Assert.IsTrue(t.Contains(635));
            t.Remove(930);
            t.Add(787);
            t.Add(334);
            Assert.IsTrue(t.Contains(534));
            Assert.IsTrue(t.Contains(391));
            t.Add(765);
        }

        [Test]
        public void Should_UseMyHashSet_Bit()
        {
            var t = new Task705.MyHashSet_Bit();
            t.Add(1);
            t.Add(2);
            Assert.IsTrue(t.Contains(1));
            Assert.IsFalse(t.Contains(3));
            t.Add(2);
            Assert.IsTrue(t.Contains(2));
            t.Remove(2);
            Assert.IsFalse(t.Contains(2));
            t.Add(1000000);
            Assert.IsTrue(t.Contains(1000000));
        }

        [Test]
        public void Should_UseMyHashSet_List()
        {
            var t = new Task705.MyHashSet_LL();
            t.Add(1);
            t.Add(2);
            t.Add(5);
            t.Add(8);
            t.Add(10);
            Assert.IsTrue(t.Contains(1));
            Assert.IsFalse(t.Contains(3));
            t.Add(2);
            Assert.IsTrue(t.Contains(2));
            t.Remove(2);
            Assert.IsFalse(t.Contains(2));
            t.Add(1000000);
            Assert.IsTrue(t.Contains(1000000));
        }
    }
}
