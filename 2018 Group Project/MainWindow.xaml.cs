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

        private unitManager newlist;

        private string unitid;

        public MainWindow()
        {
            InitializeComponent();
            
        }


        private void savelist_Click(object sender, RoutedEventArgs e)
        {
            newlist.saveArmy();
        }
        private void printarmy_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "";
            newlist.printArmy();
        }
        
        

        private void makelist_Click(object sender, RoutedEventArgs e)
        { //newlist = new unitManager();
           UnitDisplay.Text = "New list made";
           TextBox.Text = "";
 
        }




        private void Button_Click(object sender, RoutedEventArgs e) {

            unitid = "01111601";
            newlist.readDB(unitid);
            

        }

        private void addLegionPraetor(object sender, RoutedEventArgs e)
        {
            unitid = "01111601";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:11 unitid:1601";
        }


        private void Button_Click_1(object sender, RoutedEventArgs e) {
            unitid = "01111801";
            newlist.addUnit(unitid);

        }

        private void addLegionCenturion(object sender, RoutedEventArgs e)
        {
            unitid = "01111801";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:11 unitid:1801";
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            unitid = "01112601";
            newlist.addUnit(unitid);

        }


        private void addCommandSquad(object send, RoutedEventArgs e)
        {
            unitid = "01112601";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:11 unitid:2601 and 2602";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            unitid = "01122801";
            newlist.addUnit(unitid);
        }


        private void addLegionVeteranTacticalSquad(object sender, RoutedEventArgs e)
        {
            unitid = "01122801";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:12 unitid:2801 and 2802";
        }


        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            unitid = "01122901";
            newlist.addUnit(unitid);
        }


        private void addLegionDestroyerSquad(object sender, RoutedEventArgs e)
        {
            unitid = "01122901";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:12 unitid:2901 and 2902"; 
        }


        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            unitid = "01123001";
            newlist.addUnit(unitid);

        }


        private void addLegionTerminatorSquad(object sender, RoutedEventArgs e)
        {
            unitid = "01123001";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:12 unitid:3001 and 3002";
        }


        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

            unitid = "01123101";
            newlist.addUnit(unitid);
        }


        private void addTechmarineCovenant(object sender, RoutedEventArgs e)
        {
            unitid = "01123101";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:12 unitid:3101 and 3102";
        }


        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            unitid = "01123201";
            newlist.addUnit(unitid);

        }


        private void addApothicarionDetachment(object sender, RoutedEventArgs e)
        {
            unitid = "01123201";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:12 unitid:3201"; 
        }


        private void Button_Click_8(object sender, RoutedEventArgs e) {
            unitid = "01123501";
            newlist.addUnit(unitid);
        }

        private void addLegionRapierWeaponsBattery(object sender, RoutedEventArgs e)
        {
            unitid = "01123501";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:12 unitid:3501 and 3502";
        }


        private void Button_Click_9(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionTacticalSquad(object sender, RoutedEventArgs e)
        {
            unitid = "01134002";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:13 unitid:4001, 4002, 4101, 4102";
        }


        private void Button_Click_10(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionBreacherSiegeSquad(object sender, RoutedEventArgs e)
        {
            unitid = "01134201";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:13 unitid:4201, 4202";
        }


        private void Button_Click_11(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);


        }

        private void addLegionTacticalSupportSquad(object sender, RoutedEventArgs e)
        {
            unitid = "01134301";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:13 unitid:4301, 4302";
        }


        private void Button_Click_12(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionReconnaissanceSquad(object sender, RoutedEventArgs e)
        {
            unitid = "01134401";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:13 unitid:4401"; 
        }


        private void legonseekersquad_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionSeekerSquad(object sender, RoutedEventArgs e)
        {
            unitid = "01154801";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid 15, unitid: 4801, 4802"; 
        }


        private void LegionOutriderSquad_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionOutriderSquad(object sender, RoutedEventArgs e)
        {
              unitid = "01154901";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:15, unitid:4901, 4902";
        }


        private void Legion_Attack_Bike_Squad_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionAttackBikeSquad_Click(object sender, RoutedEventArgs e)
        {
              unitid = "01155001";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:15 unitid: 5001";
        }


        private void LegionJetbikeHunterSquadron_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionJetbikeHunterSquadron_Click(object sender, RoutedEventArgs e)
        {
              unitid = "01155101";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:15 unitid: 5101, 5102";
        }


        private void Legiontarantulasentrygunbattery_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionTarantulaSentryGunBattery(object sender, RoutedEventArgs e)
        {
              unitid = "01155401";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:15 unitid:5401, ";
        }


        private void Legionjetbikesky_slayersupportsquadron_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionJetbikeSkyslayerSupportSquadron(object sender, RoutedEventArgs e)
        {
              unitid = "01166001";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:16 unitid:6001, 6002"; 
        }



        private void Legionheavysupportsquad_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionHeavySupportSquad(object sender, RoutedEventArgs e)
        {
              unitid = "01166201";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:16 unitid:6201 6202";
        }


        private void DamoclesCommandRhino_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addDamoclesCommandRhino(object sender, RoutedEventArgs e)
        {
              unitid = "02112501";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:11 unitid:2501";
        }


        private void LegionRhinoArmouredCarrier__Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionRhinoArmouredCarrier(object sender, RoutedEventArgs e)
        {
              unitid = "02144501";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:16 unitid:4501"; 
        }


        private void LegionDropPod_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionDropPod(object sender, RoutedEventArgs e)
        {
              unitid = "02144601";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:14 unitid:4601";
        }


        private void LegionDreadnoughtDropPod_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionDreadnoughtDropPod(object sender, RoutedEventArgs e)
        {
              unitid = "02144701";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:14 unitid:4701";
        }


        private void PrimarisLightningStrikeFighter_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addPrimarisLightningStrikeFighter(object sender, RoutedEventArgs e)
        {
              unitid = "02155201";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:15 unitid:5201";
        }


        private void AnvillusPatternDreadclawDropPod_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addAnvillusPatternDreadclawDropPod(object sender, RoutedEventArgs e)
        {
              unitid = "02155501";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:15 unitid:5501";
        }


        private void LegionLandSpeederSquadron_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionLandSpeederSquadron_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02155601";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:15 unitid:5601";
        }



        private void LegionStormEagleAssaultGunship_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionStormEagleAssaultGunship_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02155701";
         
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:15 unitid:5701";
        }



        private void XiphonPatternInterceptor_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addXiphonPatternInterceptor_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02155801";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:15 unitid:5801"; 
        }



        private void LegionJavelinAttackSpeederSquadron_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionJavelinAttackSpeederSquadron_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02155901";
          
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:15 unitid:5901";
        }



        private void DeathStormDropPod_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addDeathStormDropPod_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02169001";
          
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:16 unitid:9001";
        }



        private void LegionPredatorStrikeSquadron_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionPredatorStrikeSquadron_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02166301";
          
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:16 unitid:6301";
        }


        private void LegionLandRaiderBattleSquadronPhobos_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionLandRaiderBattleSquadronPhobos_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02166401";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:16 unitid:6401";
        }



        private void LegionLandRaiderBattleSquadronProteus_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionLandRaiderBattleSquadronProteus_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02166411";
        
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:16 unitid:6411";
        }


        private void LegionLandRaiderBattleSquadronAchilles_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionLandRaiderBattleSquadronAchilles_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02166421";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:16 unitid:6421";
        }



        private void LegionFireRaptorGunship_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionFireRaptorGunship_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02166601";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "class id16 unitid:6601";
        }


        private void AchillesAlphaPatternLandRaider_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addAchillesAlphaPatternLandRaider_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02166701";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:16 unitid:6701";
        }


        private void LegionBasiliskArtillerySquadron_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionBasiliskArtillerySquadron_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02166801";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:16 unitid6801";
        }



        private void LegionMedusaArtilleryTankSquadron_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionMedusaArtilleryTankSquadron_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02166811";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:16 unitid:6811";
        }



        private void LegionWhirlwindArtilleryTankSquadron_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionWhirlwindArtilleryTankSquadron_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02166821";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:16 unitid:6821";
        }


        private void LegionVindicatorSiegeTankSquadron_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionVindicatorSiegeTankSquadron_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02166801";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:16 unitid:6901";
        }


        private void LegionSpartanAssaultTank_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionSpartanAssaultTank_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02167001";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:16 unitid:7001"; 
        }



        private void LegionCaestusAssaultRam_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionCaestusAssaultRam_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02167101";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:16 unitid:7101"; 
        }

        private void SicaranVenatorTankDestroyer_Click(object sender, RoutedEventArgs e){
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addSicaranVenatorTankDestroyer_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02167201";
          
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
        }



        private void LegionSicaranBattleTank_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionSicaranBattleTank_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02167301";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:16 unitid:7301";
        }



        private void LegionKharybdisAssaultClaw_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionKharybdisAssaultClaw_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02167401";
          
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:16 unitid:7401";
        }



        private void LegionWhirlwindScorpius_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionWhirlwindScorpius_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02168001";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:16 unitid:8001"; 
        }



        private void LegionMalcadorAssaultTank_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionMalcadorAssaultTank_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02168101";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:16 unitid:8101";
        }



        private void LegionCerberusHeavyTankDestroyer_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionCerberusHeavyTankDestroyer_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02178201";
          
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:17 unitid:8201";
        }


        private void LegionTyphonHeavySiegeTank_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionTyphonHeavySiegeTank_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02178301";
         
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:17 unitid:8301";
        }


        private void LegionFalchionSuperHeavyTankDestroyer_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionFalchionSuperHeavyTankDestroyer_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02178401";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:17 unitid:8401";
        }


        private void LegionStormbladeSuperhHeayTank_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionStormbladeSuperhHeayTank_Click(object sender, RoutedEventArgs e)
        {
              unitid = "01111601";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:17 unitid:8501"; 
        }

        private void LegionFellbladeSuperHeavyTank_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionFellbladeSuperHeavyTank_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02178601";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:17 unitid:8601";
        }


        private void LegionGlaiveSuperHeavyTank_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid); 
        }

        private void addLegionGlaiveSuperHeavyTank_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02178701";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:17 unitid:8701";
        }


        private void LegionThunderhawkTransporter_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionThunderhawkTransporter_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02178801";
          
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:17 unitid:8801";
        }


        private void LegionThunderhawkGunship_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionThunderhawkGunship_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02178901";
        
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:17 unitid:8901";
        }


        private void LegionMastodonHeavyAssaultTransport_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionMastodonHeavyAssaultTransport_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02179001";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:17 unitid:9001";
        }


        private void SokarPatternStormbird_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addSokarPatternStormbird_Click(object sender, RoutedEventArgs e)
        {
              unitid = "02179201";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "clasid:17 unitid:9201";
        }


        private void LegionDreadnoughtTalon_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionDreadnoughtTalon_Click(object sender, RoutedEventArgs e)
        {
              unitid = "03123301";
         
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:12 unitid:3301"; 
        }


        private void ContemptorDreadnoughtTalon_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addContemptorDreadnoughtTalon_Click(object sender, RoutedEventArgs e)
        {
              unitid = "03123401";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:12 unitid:3401";
        }


        private void LegionMortisDreadnought_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLegionMortisDreadnought_Click(object sender, RoutedEventArgs e)
        {
              unitid = "03123601";
            
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:12 unitid:3601"; 
        }


        private void ContemptorMortisDreadnought_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addContemptorMortisDreadnought_Click(object sender, RoutedEventArgs e)
        {
              unitid = "03123701";
         
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:12 unitid:3701";
        }


        private void ContemptorCortusClassDreadnoughtTalon_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addContemptorCortusClassDreadnoughtTalon_Click(object sender, RoutedEventArgs e)
        {
              unitid = "03123801";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid12 unitid:3801";
        }


        private void LeviathanPatternSiegeDreadnoughtTalon_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addLeviathanPatternSiegeDreadnoughtTalon_Click(object sender, RoutedEventArgs e)
        {
              unitid = "03167601";
      
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:16 unitid7601";
        }


        private void DeredeoPatternDreadnought_Click(object sender, RoutedEventArgs e) {
            unitid = "01111601";
            newlist.addUnit(unitid);
        }

        private void addDeredeoPatternDreadnought_Click(object sender, RoutedEventArgs e)
        {
              unitid = "03167801";
           
            newlist.addUnit(unitid);
            TextBox.Text = "";
            newlist.printArmy();
            //TextBox.Text = "classid:? unitid:3301"; 
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
              unitid = IndexBox.Text;

            newlist.removeUnit(unitid);

            TextBox.Text = "";

            newlist.printArmy();
        }

        private void _2500Picker_Click(object sender, RoutedEventArgs e)
        {
            newlist = new unitManager(2500); TextBox.Text = "New list made";
        }

        private void _1500Picker_Click(object sender, RoutedEventArgs e)
        {
            newlist = new unitManager(1500); TextBox.Text = "New list made";
        }

        private void CustomPointConfirm_Click(object sender, RoutedEventArgs e)
        {
            newlist = new unitManager( Convert.ToInt32(PointBox.Text)); TextBox.Text = "New list made";
        }

        private void FuturehomeofsaveList_Click(object sender, RoutedEventArgs e)
        {
            newlist.saveArmy();
        }
    }
}
