using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2018_Group_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private unitManager newlist = null;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void savelist_Click(object sender, RoutedEventArgs e)
        {
            UnitDisplay.Text = "SaveListNotImplemented";
        }
        private void printarmy_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "";
            newlist.printArmy();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Praetor" + "\n" + "Infantry" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionPraetor(object sender, RoutedEventArgs e)
        {
            string unitid = "01111601";
            string unitname = "Legion Praetor";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:11 unitid:1601";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Centurion" + "\n" + "Infantry" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionCenturion(object sender, RoutedEventArgs e)
        {
            string unitid = "01111801";
            string unitname = "Legion Centurion";
            newlist.addUnit(unitid, unitname); //TextBox.Text = "classid:11 unitid:1801";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        { UnitDisplay.Text = "Legion Command Squad" + "\n" + "Infantry" + "\n" + "Statline: " + "\n" + "Other Information"; }

        private void addCommandSquad(object send, RoutedEventArgs e)
        {
            string unitid = "01112601";
            string unitname = "Legion Command Squad";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:11 unitid:2601 and 2602";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        { UnitDisplay.Text = "Legion Veteran Tactical Squad" + "\n" + "Infantry" + "\n" + "Statline: " + "\n" + "Other Information"; }

        private void addLegionVeteranTacticalSquad(object sender, RoutedEventArgs e)
        {
            string unitid = "01122801";
            string unitname = "Legion Veteran Tactical Squad";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:12 unitid:2801 and 2802";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        { UnitDisplay.Text = "Legion Destroyer Squad" + "\n" + "Infantry" + "\n" + "Statline: " + "\n" + "Other Information"; }

        private void addLegionDestroyerSquad(object sender, RoutedEventArgs e)
        {
            string unitid = "01122901";
            string unitname = "Legion Destroyer Squad";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:12 unitid:2901 and 2902"; 
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        { UnitDisplay.Text = "Legion Terminator Squad" + "\n" + "Infantry" + "\n" + "Statline: " + "\n" + "Other Information"; }

        private void addLegionTerminatorSquad(object sender, RoutedEventArgs e)
        {
            string unitid = "01123001";
            string unitname = "Legion Terminator Squad";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:12 unitid:3001 and 3002";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        { UnitDisplay.Text = " Techmarine Covenant" + "\n" + "Infantry" + "\n" + "Statline: " + "\n" + "Other Information"; }

        private void addTechmarineCovenant(object sender, RoutedEventArgs e)
        {
            string unitid = "01123101";
            string unitname = "Techmarine Covenant";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:12 unitid:3101 and 3102";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        { UnitDisplay.Text = "Apothicarion Detachment" + "\n" + "Infantry" + "\n" + "Statline: " + "\n" + "Other Information"; }

        private void addApothicarionDetachment(object sender, RoutedEventArgs e)
        {
            string unitid = "01123201";
            string unitname = "Apothicarion Detachment";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:12 unitid:3201"; 
        }

        private void Button_Click_8(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Rapier Weapons Battery" + "\n" + "Infantry" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionRapierWeaponsBattery(object sender, RoutedEventArgs e)
        {
            string unitid = "01123501";
            string unitname = "Legion Rapier Weapons Battery";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:12 unitid:3501 and 3502";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Tactical Squad" + "\n" + "Infantry" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionTacticalSquad(object sender, RoutedEventArgs e)
        {
            string unitid = "01134001";
            string unitname = "Legion Tactical Squad";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:13 unitid:4001, 4002, 4101, 4102";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Breacher Siege-Squad" + "\n" + "Infantry" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionBreacherSiegeSquad(object sender, RoutedEventArgs e)
        {
            string unitid = "01134201";
            string unitname = "Legion Breacher Siege-Squad";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:13 unitid:4201, 4202";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Tactical Support Squad" + "\n" + "Infantry" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionTacticalSupportSquad(object sender, RoutedEventArgs e)
        {
            string unitid = "01134301";
            string unitname = "Legion Tactical Support Squad";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:13 unitid:4301, 4302";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Reconnaissance Squad" + "\n" + "Infantry" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionReconnaissanceSquad(object sender, RoutedEventArgs e)
        {
            string unitid = "01134401";
            string unitname = "Legion Reconnaissance Squad";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:13 unitid:4401"; 
        }

        private void legonseekersquad_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Seeker Squad" + "\n" + "Infantry" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionSeekerSquad(object sender, RoutedEventArgs e)
        {
            string unitid = "01154801";
            string unitname = "Legion Seeker Squad";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid 15, unitid: 4801, 4802"; 
        }

        private void LegionOutriderSquad_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Outrider Squad" + "\n" + "Infantry" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionOutriderSquad(object sender, RoutedEventArgs e)
        {
            string unitid = "01154901";
            string unitname = "Legion Outrider Squad";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:15, unitid:4901, 4902";
        }

        private void Legion_Attack_Bike_Squad_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Attack Bike Squad" + "\n" + "Infantry" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionAttackBikeSquad_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "01155001";
            string unitname = "Legion Attack Bike Squad";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:15 unitid: 5001";
        }

        private void LegionJetbikeHunterSquadron_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Jetbike Hunter Squadron" + "\n" + "Infantry" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionJetbikeHunterSquadron_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "01155101";
            string unitname = "Legion Jetbike Hunter Squadron";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:15 unitid: 5101, 5102";
        }

        private void Legiontarantulasentrygunbattery_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Tarantula Sentry Gun-Battery" + "\n" + "Infantry" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionTarantulaSentryGunBattery(object sender, RoutedEventArgs e)
        {
            string unitid = "01155401";
            string unitname = "Legion Tarantula Sentry-Gun Battery";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:15 unitid:5401, ";
        }

        private void Legionjetbikesky_slayersupportsquadron_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Jetbike Sky-Slayer Support Squadron" + "\n" + "Infantry" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionJetbikeSkyslayerSupportSquadron(object sender, RoutedEventArgs e)
        {
            string unitid = "01166001";
            string unitname = "Legion Jetbike Sky-slayer support squadron";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:16 unitid:6001, 6002"; 
        }


        private void Legionheavysupportsquad_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Heavy Support Squad" + "\n" + "Infantry" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionHeavySupportSquad(object sender, RoutedEventArgs e)
        {
            string unitid = "01166201";
            string unitname = "Legion Heavy Support Squad";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:16 unitid:6201 6202";
        }

        private void DamoclesCommandRhino_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Damocles Command Rhino" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addDamoclesCommandRhino(object sender, RoutedEventArgs e)
        {
            string unitid = "02112501";
            string unitname = "Damocles Command Rhino";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:11 unitid:2501";
        }

        private void LegionRhinoArmouredCarrier__Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Rhino Armoured Carrier" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionRhinoArmouredCarrier(object sender, RoutedEventArgs e)
        {
            string unitid = "02144501";
            string unitname = "Legion Rhino Armoured Carier";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:16 unitid:4501"; 
        }

        private void LegionDropPod_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Drop Pod" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionDropPod(object sender, RoutedEventArgs e)
        {
            string unitid = "02144601";
            string unitname = "Legion Drop Pod";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:14 unitid:4601";
        }

        private void LegionDreadnoughtDropPod_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Dreadnought Drop Pod" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionDreadnoughtDropPod(object sender, RoutedEventArgs e)
        {
            string unitid = "02144701";
            string unitname = "Legion Dreadnought Drop Pod";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:14 unitid:4701";
        }

        private void PrimarisLightningStrikeFighter_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Primaris-Lightning Strike Fighter" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addPrimarisLightningStrikeFighter(object sender, RoutedEventArgs e)
        {
            string unitid = "02155201";
            string unitname = "Primaris-Lightning Strike Fighter";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:15 unitid:5201";
        }

        private void AnvillusPatternDreadclawDropPod_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Anvillus Pattern Dreadclaw Drop Pod" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addAnvillusPatternDreadclawDropPod(object sender, RoutedEventArgs e)
        {
            string unitid = "02155501";
            string unitname = "Anvillus Pattern Dreadclaw Drop Pod";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:15 unitid:5501";
        }

        private void LegionLandSpeederSquadron_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Land Speeder Squadron" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionLandSpeederSquadron_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02155601";
            string unitname = "Legion Land Speeder Squadron";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:15 unitid:5601";
        }


        private void LegionStormEagleAssaultGunship_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Storm Eagle Assault Gunship" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionStormEagleAssaultGunship_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02155701";
            string unitname = "Legion Storm Eagle Assault Gunship";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:15 unitid:5701";
        }


        private void XiphonPatternInterceptor_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Xiphon Pattern Interceptor" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addXiphonPatternInterceptor_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02155801";
            string unitname = "Xiphon Pattern Interceptor";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:15 unitid:5801"; 
        }


        private void LegionJavelinAttackSpeederSquadron_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Javelin Attack Speeder Squadron" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionJavelinAttackSpeederSquadron_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02155901";
            string unitname = "Legion Javelin Attack Speeder Squadron";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:15 unitid:5901";
        }


        private void DeathStormDropPod_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "DeathStorm Drop Pod" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addDeathStormDropPod_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02169001";
            string unitname = "DeathStorm Drop Pod";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:16 unitid:9001";
        }


        private void LegionPredatorStrikeSquadron_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Predator Strike Squadron" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionPredatorStrikeSquadron_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02166301";
            string unitname = "Legion Predator Strike Squadron";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:16 unitid:6301";
        }

        private void LegionLandRaiderBattleSquadronPhobos_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Land Raider Battle Squadron Phobos" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionLandRaiderBattleSquadronPhobos_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02166401";
            string unitname = "Legion Land Raider Battle Squadron Phobos";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:16 unitid:6401";
        }


        private void LegionLandRaiderBattleSquadronProteus_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Land Raider Battle Squadron Proteus" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionLandRaiderBattleSquadronProteus_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02166411";
            string unitname = "Legion Land Raider Battle Squadron Proteus";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:16 unitid:6411";
        }

        private void LegionLandRaiderBattleSquadronAchilles_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Land Raider Battle Squadron Achilles" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionLandRaiderBattleSquadronAchilles_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02166421";
            string unitname = "Legion Land Raider Battle Squadron Proteus";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:16 unitid:6421";
        }


        private void LegionFireRaptorGunship_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Fire Raptor Gunship" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionFireRaptorGunship_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02166601";
            string unitname = "Legion Fire Raptor Gunship";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "class id16 unitid:6601";
        }

        private void AchillesAlphaPatternLandRaider_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Achilles-Alpha Pattern Land Raider" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addAchillesAlphaPatternLandRaider_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02166701";
            string unitname = "Achilles-Alpha Pattern Land Raider";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:16 unitid:6701";
        }

        private void LegionBasiliskArtillerySquadron_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Basilisk Artillery Squadron" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionBasiliskArtillerySquadron_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02166801";
            string unitname = "Legion Basilisk Artillery Squadron";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:16 unitid6801";
        }


        private void LegionMedusaArtilleryTankSquadron_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Medusa Artillery Tank Squadron" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionMedusaArtilleryTankSquadron_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02166811";
            string unitname = "Legion Basilisk Artillery Squadron";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:16 unitid:6811";
        }


        private void LegionWhirlwindArtilleryTankSquadron_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Whirlwind Artillery Tank Squadron" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionWhirlwindArtilleryTankSquadron_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02166821";
            string unitname = "Legion Whirlwind Artillery Tank Squadron";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:16 unitid:6821";
        }

        private void LegionVindicatorSiegeTankSquadron_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Vindicator Siege Tank Squadron" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionVindicatorSiegeTankSquadron_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02166801";
            string unitname = "Legion Vindicator Siege Tank Squadron";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:16 unitid:6901";
        }

        private void LegionSpartanAssaultTank_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Spartan Assault Tank" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionSpartanAssaultTank_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02167001";
            string unitname = "Legion Spartan Assault Tank";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:16 unitid:7001"; 
        }


        private void LegionCaestusAssaultRam_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Caestus Assault Ram" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionCaestusAssaultRam_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02167101";
            string unitname = "Legion Caestus Assault Ram";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:16 unitid:7101"; 
        }
        private void SicaranVenatorTankDestroyer_Click(object sender, RoutedEventArgs e){ UnitDisplay.Text = "Sicaran Venator Tank Destroyer" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addSicaranVenatorTankDestroyer_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02167201";
            string unitname = "Sicaran Venator Tank Destroyer";
            newlist.addUnit(unitid, unitname);
            }


        private void LegionSicaranBattleTank_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Sicaran Battle Tank" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionSicaranBattleTank_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02167301";
            string unitname = "Legion Sicaran Battle Tank";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:16 unitid:7301";
        }


        private void LegionKharybdisAssaultClaw_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Kharybdis Assault Claw" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionKharybdisAssaultClaw_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02167401";
            string unitname = "Legion Kharybdis Assault Claw";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:16 unitid:7401";
        }


        private void LegionWhirlwindScorpius_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Whirlwind Scorpius" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionWhirlwindScorpius_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02168001";
            string unitname = "Legion Whirlwind Scorpius";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:16 unitid:8001"; 
        }


        private void LegionMalcadorAssaultTank_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Malcador Assault Tank" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionMalcadorAssaultTank_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02168101";
            string unitname = "Legion Malcador Assault Tank";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:16 unitid:8101";
        }


        private void LegionCerberusHeavyTankDestroyer_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Cerberus Heavy Tank Destroyer" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionCerberusHeavyTankDestroyer_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02178201";
            string unitname = "Legion Cerberus Heavy Tank Destroyer";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:17 unitid:8201";
        }

        private void LegionTyphonHeavySiegeTank_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Typhon Heavy Siege Tank" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionTyphonHeavySiegeTank_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02178301";
            string unitname = "Legion Typhon Heavy Siege Tank";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:17 unitid:8301";
        }

        private void LegionFalchionSuperHeavyTankDestroyer_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Falchion Super-Heavy Tank Destroyer" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionFalchionSuperHeavyTankDestroyer_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02178401";
            string unitname = "Legion Falchion Super-Heavy Tank Destroyer";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:17 unitid:8401";
        }

        private void LegionStormbladeSuperhHeayTank_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion stormblade Super-heay tank" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionStormbladeSuperhHeayTank_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "01111601";
            string unitname = "Legion Stormblade Super-Heavy Tank";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:17 unitid:8501"; 
        }

        private void LegionFellbladeSuperHeavyTank_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Fellblade Super-heavy Tank" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionFellbladeSuperHeavyTank_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02178601";
            string unitname = "Legion Fellblade Super-heavy Tank";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:17 unitid:8601";
        }

        private void LegionGlaiveSuperHeavyTank_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Glaive Super-heavy Tank" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionGlaiveSuperHeavyTank_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02178701";
            string unitname = "Legion Glaive Super-heavy Tank";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:17 unitid:8701";
        }

        private void LegionThunderhawkTransporter_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Thunderhawk Transporter" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionThunderhawkTransporter_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02178801";
            string unitname = "Legion Thunderhawk Transporter";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:17 unitid:8801";
        }

        private void LegionThunderhawkGunship_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Thunderhawk Gunship" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionThunderhawkGunship_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02178901";
            string unitname = "Legion Thunderhawk Gunship";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:17 unitid:8901";
        }

        private void LegionMastodonHeavyAssaultTransport_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Mastodon Heavy Assault Transport" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionMastodonHeavyAssaultTransport_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02179001";
            string unitname = "Legion Mastodon Heavy Assault Transport";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:17 unitid:9001";
        }

        private void SokarPatternStormbird_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Sokar Pattern Stormbird" + "\n" + "Vehicle" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addSokarPatternStormbird_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "02179201";
            string unitname = "Sokar Pattern Stormbird";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "clasid:17 unitid:9201";
        }

        private void LegionDreadnoughtTalon_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Dreadnought Talon" + "\n" + "Walker" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionDreadnoughtTalon_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "03123301";
            string unitname = "Legion Dreadnought Talon";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:12 unitid:3301"; 
        }

        private void ContemptorDreadnoughtTalon_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Contemptor Dreadnought Talon" + "\n" + "Walker" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addContemptorDreadnoughtTalon_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "03123401";
            string unitname = "Contemptor Dreadnought Talon";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:12 unitid:3401";
        }

        private void LegionMortisDreadnought_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Legion Mortis Dreadnought" + "\n" + "Walker" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLegionMortisDreadnought_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "03123601";
            string unitname = "Legion Mortis Dreadnought";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:12 unitid:3601"; 
        }

        private void ContemptorMortisDreadnought_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Contemptor-Mortis Dreadnought" + "\n" + "Walker" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addContemptorMortisDreadnought_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "03123701";
            string unitname = "Contemptor-Mortis Dreadnought";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:12 unitid:3701";
        }

        private void ContemptorCortusClassDreadnoughtTalon_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Contemptor Cortus Class Dreadnought Talon" + "\n" + "Walker" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addContemptorCortusClassDreadnoughtTalon_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "03123801";
            string unitname = "Contemptor Cortus Class Dreadnought Talon";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid12 unitid:3801";
        }

        private void LeviathanPatternSiegeDreadnoughtTalon_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Leviathan Pattern Siege Dreadnought Talon" + "\n" + "Walker" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addLeviathanPatternSiegeDreadnoughtTalon_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "03167601";
            string unitname = "Leviathan Pattern Siege Dreadnought Talon";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:16 unitid7601";
        }

        private void DeredeoPatternDreadnought_Click(object sender, RoutedEventArgs e) { UnitDisplay.Text = "Deredeo Pattern Dreadnought" + "\n" + "Walker" + "\n" + "Statline: " + "\n" + "Other Information"; }
        private void addDeredeoPatternDreadnought_Click(object sender, RoutedEventArgs e)
        {
            string unitid = "03167801";
            string unitname = "Deredeo Pattern Dreadnought";
            newlist.addUnit(unitid, unitname);
            //TextBox.Text = "classid:? unitid:3301"; 
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            string unitI = IndexBox.Text;

            newlist.removeUnit(unitI);

            TextBox.Text = "";

            newlist.printArmy();
        }

        private void _2500Picker_Click(object sender, RoutedEventArgs e)
        {
            newlist = new unitManager(); TextBox.Text = "New list made";
        }

        private void _1500Picker_Click(object sender, RoutedEventArgs e)
        {
            newlist = new unitManager(); TextBox.Text = "New list made";
        }

        private void CustomPointConfirm_Click(object sender, RoutedEventArgs e)
        {
            newlist = new unitManager(); TextBox.Text = "New list made";
        }
    }
}
