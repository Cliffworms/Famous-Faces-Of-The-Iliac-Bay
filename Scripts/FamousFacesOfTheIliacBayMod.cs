// Project:         Famous Faces of the Iliac Bay for Daggerfall Unity (http://www.dfworkshop.net)
// Copyright:       Copyright (C) 2022 Cliffworms
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Author:          Hazelnut & Cliffworms

using System;
using UnityEngine;
using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Game.Serialization;
using DaggerfallWorkshop.Game.Utility;
using DaggerfallWorkshop.Game.Utility.ModSupport;
using DaggerfallWorkshop.Utility.AssetInjection;
using DaggerfallWorkshop.Utility;

namespace FamousFacesOfTheIliacBay
{
    public class FamousFacesOfTheIliacBayMod : MonoBehaviour
    {
        private const string variantLainlyn = "_lainlyn";
        private const string variantYkalon = "_ykalon";
        private const string variantGlenpoint = "_glenpoint";
        private const string variantGraymore = "_graymore";
        private const string variantBubissidata = "_bubissidata";
        private const string variantRipfort = "_ripfort";
        private const string variantHebu = "_hebu";
        private const string variantKambria = "_kambria";
        private const string variantNorthmoor = "_northmoor";
        private const string variantDaenia = "_daenia";
        private const string variantEphesus = "_ephesus";
        private const string variantIlessanHills = "_ilessanhills";
        private const string variantKozanset = "_kozanset";
        private const string variantMenevia = "_menevia";
        private const string variantMournoth = "_mournoth";
        private const string variantPhrygias = "_phrygias";
        private const string variantSantaki = "_santaki";
        private const string variantUrvaius = "_urvaius";
        private const string variantBhoriane = "_bhoriane";
        private const string variantSatakalaam = "_satakalaam";
        private const string variantAlcaire = "_alcaire";
        private const string variantDwynnen = "_dwynnen";
        private const string variantGavaudon = "_gavaudon";
        private const string variantGlenumbra = "_glenumbra";
        private const string variantShalgora = "_shalgora";
        private const string variantTigonus = "_tigonus";
        private const string variantTotambu = "_totambu";
        private const string variantTulune = "_tulune";
        private const string variantAbibonGora = "_abibongora";
        private const string variantMerwarkHollow = "_merwarkhollow";
        private const string variantKairou = "_kairou";
        private const string variantPothago = "_pothago";
        private const string variantWayrest = "_wayrest";
        private const string variantDaggerfall = "_daggerfall";
        private const string variantDragontail = "_dragontail";
        private const string variantAyasofya = "_ayasofya";
        private const string variantMyrkwasa = "_myrkwasa";
        private const string variantAlikr = "_alikr";
        private const string variantBergama = "_bergama";
        private const string variantWrothgaria = "_wrothgaria";
        private const string variantAntiphyllos = "_antiphyllos";
        private const string variantAnticlere = "_anticlere";



        static Mod mod;

        [Invoke(StateManager.StateTypes.Start, 0)]
        public static void Init(InitParams initParams)
        {
            mod = initParams.Mod;
            var go = new GameObject(mod.Title);
            go.AddComponent<FamousFacesOfTheIliacBayMod>();
        }

        void Start()
        {
            Debug.Log("Begin mod init: FamousFacesOfTheIliacBay");

            SaveLoadManager.OnLoad += SaveLoadManager_OnLoad;
            StartGameBehaviour.OnStartGame += StartGameBehaviour_OnStartGame;

            RDBLayout.NPCFlatArchives.Add(1200);

            // Add DET archives too, but make sure they're not already there

            // Named/Unique NPCs
            if (!RDBLayout.NPCFlatArchives.Contains(1020))
                RDBLayout.NPCFlatArchives.Add(1020);

            mod.IsReady = true;
            Debug.Log("Finished mod init: FamousFacesOfTheIliacBay");
        }


        public void StartGameBehaviour_OnStartGame(object sender, EventArgs e)
        {
            InitVariants();
        }

        void SaveLoadManager_OnLoad(SaveData_v1 saveData)
        {
            InitVariants();
        }

        void InitVariants()
        {
            // Hebu (161) in region 22
            if (WorldDataVariants.GetBuildingVariant(22, 161, "TEMPAAH0.RMB", 13) == WorldDataVariants.NoVariant)
            {
                int locHebu = WorldDataReplacement.MakeLocationKey(22, 161);
                WorldDataVariants.SetBuildingVariant("TEMPAAH0.RMB", 13, variantHebu, locHebu);
            }  

            // Anticlere Palace (600) in region 21
            if (WorldDataVariants.GetBlockVariant("PALAAA02.RMB") == WorldDataVariants.NoVariant)
            {
                int locAnticlere = WorldDataReplacement.MakeLocationKey(21, 600);
                WorldDataVariants.SetBlockVariant("PALAAA02.RMB", variantAnticlere, locAnticlere);
            }      

            // Anticlere Thieves Guild (600) in region 21
            if (WorldDataVariants.GetBuildingVariant(21, 600, "THIEAL00.RMB", 0) == WorldDataVariants.NoVariant)
            {
                int locAnticlere = WorldDataReplacement.MakeLocationKey(21, 600);
                WorldDataVariants.SetBuildingVariant("THIEAL00.RMB", 0, variantAnticlere, locAnticlere);
            }      

            // Abibon-gora (78) in region 43
            if (WorldDataVariants.GetBlockVariant("PALAGA01.RMB") == WorldDataVariants.NoVariant)
            {
                int locAbibonGora = WorldDataReplacement.MakeLocationKey(43, 78);
                WorldDataVariants.SetBlockVariant("PALAGA01.RMB", variantAbibonGora, locAbibonGora);
            }                                        

            // Bubissidata (2) in region 20
            if (WorldDataVariants.GetBuildingVariant(20, 2, "THIEAL00.RMB", 16) == WorldDataVariants.NoVariant)
            {
                int locBubissidata = WorldDataReplacement.MakeLocationKey(20, 2);
                WorldDataVariants.SetBuildingVariant("THIEAL00.RMB", 16, variantBubissidata, locBubissidata);
            }

            // Pothago (6) in region 45
            if (WorldDataVariants.GetBlockVariant("PALAGA01.RMB") == WorldDataVariants.NoVariant)
            {
                int locPothago = WorldDataReplacement.MakeLocationKey(45, 6);
                WorldDataVariants.SetBlockVariant("PALAGA01.RMB", variantPothago, locPothago);
            } 

            // Kairou (97) in region 44
            if (WorldDataVariants.GetBlockVariant("PALAGA04.RMB") == WorldDataVariants.NoVariant)
            {
                int locKairou = WorldDataReplacement.MakeLocationKey(44, 97);
                WorldDataVariants.SetBlockVariant("PALAGA04.RMB", variantKairou, locKairou);
            } 

            // Ayasofya (128) in region 47
            if (WorldDataVariants.GetBlockVariant("PALABA04.RMB") == WorldDataVariants.NoVariant)
            {
                int locAyasofya = WorldDataReplacement.MakeLocationKey(47, 128);
                WorldDataVariants.SetBlockVariant("PALABA04.RMB", variantAyasofya, locAyasofya);
            }   

            // Antiphyllos (39) in region 55
            if (WorldDataVariants.GetBlockVariant("PALABA02.RMB") == WorldDataVariants.NoVariant)
            {
                int locAntiphyllos = WorldDataReplacement.MakeLocationKey(55, 39);
                WorldDataVariants.SetBlockVariant("PALABA02.RMB", variantAntiphyllos, locAntiphyllos);
            }    

            // Myrkwasa (57) in region 46
            if (WorldDataVariants.GetBlockVariant("PALAGA03.RMB") == WorldDataVariants.NoVariant)
            {
                int locMyrkwasa = WorldDataReplacement.MakeLocationKey(46, 57);
                WorldDataVariants.SetBlockVariant("PALAGA03.RMB", variantMyrkwasa, locMyrkwasa);
            }                         

            // Alik'ra (165) in region 0
            if (WorldDataVariants.GetBlockVariant("PALABA03.RMB") == WorldDataVariants.NoVariant)
            {
                int locAlikr = WorldDataReplacement.MakeLocationKey(0, 165);
                WorldDataVariants.SetBlockVariant("PALABA03.RMB", variantAlikr, locAlikr);
            }      

            // Bergama (41) in region 56
            if (WorldDataVariants.GetBlockVariant("PALABA00.RMB") == WorldDataVariants.NoVariant)
            {
                int locBergama = WorldDataReplacement.MakeLocationKey(56, 41);
                WorldDataVariants.SetBlockVariant("PALABA00.RMB", variantBergama, locBergama);
            }    

            // Tulune (59) in region 58
            if (WorldDataVariants.GetBlockVariant("PALAAA02.RMB") == WorldDataVariants.NoVariant)
            {
                int locTulune = WorldDataReplacement.MakeLocationKey(58, 59);
                WorldDataVariants.SetBlockVariant("PALAAA02.RMB", variantTulune, locTulune);
            }  

            // Totambu (633) in region 51
            if (WorldDataVariants.GetBlockVariant("PALAAA02.RMB") == WorldDataVariants.NoVariant)
            {
                int locTotambu = WorldDataReplacement.MakeLocationKey(51, 633);
                WorldDataVariants.SetBlockVariant("PALAAA02.RMB", variantTotambu, locTotambu);
            }  

            // Tigonus (54) in region 48
            if (WorldDataVariants.GetBlockVariant("PALAAA02.RMB") == WorldDataVariants.NoVariant)
            {
                int locTigonus = WorldDataReplacement.MakeLocationKey(48, 54);
                WorldDataVariants.SetBlockVariant("PALAAA02.RMB", variantTigonus, locTigonus);
            } 

            // Shalgora (161) in region 42
            if (WorldDataVariants.GetBlockVariant("PALAAA02.RMB") == WorldDataVariants.NoVariant)
            {
                int locShalgora = WorldDataReplacement.MakeLocationKey(42, 161);
                WorldDataVariants.SetBlockVariant("PALAAA02.RMB", variantShalgora, locShalgora);
            }  

            // Glenumbra (94) in region 59
            if (WorldDataVariants.GetBlockVariant("PALAAA02.RMB") == WorldDataVariants.NoVariant)
            {
                int locGlenumbra = WorldDataReplacement.MakeLocationKey(59, 94);
                WorldDataVariants.SetBlockVariant("PALAAA02.RMB", variantGlenumbra, locGlenumbra);
            }  

            // Gavaudon (24) in region 57
            if (WorldDataVariants.GetBlockVariant("PALAAA02.RMB") == WorldDataVariants.NoVariant)
            {
                int locGavaudon = WorldDataReplacement.MakeLocationKey(57, 24);
                WorldDataVariants.SetBlockVariant("PALAAA02.RMB", variantGavaudon, locGavaudon);
            }      

            // Dwynnen (522) in region 5
            if (WorldDataVariants.GetBlockVariant("PALAAA02.RMB") == WorldDataVariants.NoVariant)
            {
                int locDwynnen = WorldDataReplacement.MakeLocationKey(5, 522);
                WorldDataVariants.SetBlockVariant("PALAAA02.RMB", variantDwynnen, locDwynnen);
            } 

            // Alcaire (57) in region 34
            if (WorldDataVariants.GetBlockVariant("PALAAA02.RMB") == WorldDataVariants.NoVariant)
            {
                int locAlcaire = WorldDataReplacement.MakeLocationKey(34, 57);
                WorldDataVariants.SetBlockVariant("PALAAA02.RMB", variantAlcaire, locAlcaire);
            }  

            // Satakalaam (90) in region 50
            if (WorldDataVariants.GetBlockVariant("PALAAA01.RMB") == WorldDataVariants.NoVariant)
            {
                int locSatakalaam = WorldDataReplacement.MakeLocationKey(50, 90);
                WorldDataVariants.SetBlockVariant("PALAAA01.RMB", variantSatakalaam, locSatakalaam);
            }  

            //  Wrothgaria (297) in region 16
            if (WorldDataVariants.GetBlockVariant("PALAAA01.RMB") == WorldDataVariants.NoVariant)
            {
                int locWrothgaria = WorldDataReplacement.MakeLocationKey(16, 297);
                WorldDataVariants.SetBlockVariant("PALAAA01.RMB", variantWrothgaria, locWrothgaria);
            }              

            // Bhoriane (115) in region 36
            if (WorldDataVariants.GetBlockVariant("PALAAA01.RMB") == WorldDataVariants.NoVariant)
            {
                int locBhoriane = WorldDataReplacement.MakeLocationKey(36, 115);
                WorldDataVariants.SetBlockVariant("PALAAA01.RMB", variantBhoriane, locBhoriane);
            }      

            // Urvaius (263) in region 39
            if (WorldDataVariants.GetBlockVariant("PALAAA00.RMB") == WorldDataVariants.NoVariant)
            {
                int locUrvaius = WorldDataReplacement.MakeLocationKey(39, 263);
                WorldDataVariants.SetBlockVariant("PALAAA00.RMB", variantUrvaius, locUrvaius);
            }

            // Santaki (26) in region 54
            if (WorldDataVariants.GetBlockVariant("PALAAA00.RMB") == WorldDataVariants.NoVariant)
            {
                int locSantaki = WorldDataReplacement.MakeLocationKey(54, 26);
                WorldDataVariants.SetBlockVariant("PALAAA00.RMB", variantSantaki, locSantaki);
            }  

            // Dragontail (853) in region 1
            if (WorldDataVariants.GetBlockVariant("PALAAA00.RMB") == WorldDataVariants.NoVariant)
            {
                int locDragontail = WorldDataReplacement.MakeLocationKey(1, 853);
                WorldDataVariants.SetBlockVariant("PALAAA00.RMB", variantDragontail, locDragontail);
            }                   

            // Phrygias (167) in region 38
            if (WorldDataVariants.GetBlockVariant("PALAAA00.RMB") == WorldDataVariants.NoVariant)
            {
                int locPhrygias = WorldDataReplacement.MakeLocationKey(38, 167);
                WorldDataVariants.SetBlockVariant("PALAAA00.RMB", variantPhrygias, locPhrygias);
            }    

            // Mournoth (201) in region 52
            if (WorldDataVariants.GetBlockVariant("PALAAA00.RMB") == WorldDataVariants.NoVariant)
            {
                int locMournoth = WorldDataReplacement.MakeLocationKey(52, 201);
                WorldDataVariants.SetBlockVariant("PALAAA00.RMB", variantMournoth, locMournoth);
            } 

            // Menevia (114) in region 33
            if (WorldDataVariants.GetBlockVariant("PALAAA00.RMB") == WorldDataVariants.NoVariant)
            {
                int locMenevia = WorldDataReplacement.MakeLocationKey(33, 114);
                WorldDataVariants.SetBlockVariant("PALAAA00.RMB", variantMenevia, locMenevia);
            }  

            // Kozanset (31) in region 49
            if (WorldDataVariants.GetBlockVariant("PALAAA00.RMB") == WorldDataVariants.NoVariant)
            {
                int locKozanset = WorldDataReplacement.MakeLocationKey(49, 31);
                WorldDataVariants.SetBlockVariant("PALAAA00.RMB", variantKozanset, locKozanset);
            }   

            // Kambria (70) in region 37
            if (WorldDataVariants.GetBlockVariant("PALAAA00.RMB") == WorldDataVariants.NoVariant)
            {
                int locKambria = WorldDataReplacement.MakeLocationKey(37, 70);
                WorldDataVariants.SetBlockVariant("PALAAA00.RMB", variantKambria, locKambria);
            }      

            // Ilessan Hills (344) in region 60
            if (WorldDataVariants.GetBlockVariant("PALAAA01.RMB") == WorldDataVariants.NoVariant)
            {
                int locIlessanHills = WorldDataReplacement.MakeLocationKey(60, 344);
                WorldDataVariants.SetBlockVariant("PALAAA01.RMB", variantIlessanHills, locIlessanHills);
            }     

            // Lainlyn (103) in region 22
            if (WorldDataVariants.GetBlockVariant("PALAAA00.RMB") == WorldDataVariants.NoVariant)
            {
                int locLainlyn = WorldDataReplacement.MakeLocationKey(22, 103);
                WorldDataVariants.SetBlockVariant("PALAAA00.RMB", variantLainlyn, locLainlyn);
            }                  

            // Ykalon (357) in region 40
            if (WorldDataVariants.GetBlockVariant("PALAAA02.RMB") == WorldDataVariants.NoVariant)
            {
                int locYkalon = WorldDataReplacement.MakeLocationKey(40, 357);
                WorldDataVariants.SetBlockVariant("PALAAA02.RMB", variantYkalon, locYkalon);
            }    

            // Glenpoint (181) in region 18
            if (WorldDataVariants.GetBlockVariant("PALAAA02.RMB") == WorldDataVariants.NoVariant)
            {
                int locGlenpoint = WorldDataReplacement.MakeLocationKey(18, 181);
                WorldDataVariants.SetBlockVariant("PALAAA02.RMB", variantGlenpoint, locGlenpoint);
            }   

            // Graymore (301) in region 18
            if (WorldDataVariants.GetBuildingVariant(18, 301, "THIEAM00.RMB", 0) == WorldDataVariants.NoVariant)
            {
                int locGraymore = WorldDataReplacement.MakeLocationKey(18, 301);
                WorldDataVariants.SetBuildingVariant("THIEAM00.RMB", 0, variantGraymore, locGraymore);
            } 

            // Ripfort (410) in region 18
            if (WorldDataVariants.GetBuildingVariant(18, 410, "THIEAM00.RMB", 0) == WorldDataVariants.NoVariant)
            {
                int locRipfort = WorldDataReplacement.MakeLocationKey(18, 410);
                WorldDataVariants.SetBuildingVariant("THIEAM00.RMB", 0, variantRipfort, locRipfort);
            }                 

            // Northmoor (252) in region 32
            if (WorldDataVariants.GetBlockVariant("PALAAA00.RMB") == WorldDataVariants.NoVariant)
            {
                int locNorthmoor = WorldDataReplacement.MakeLocationKey(32, 252);
                WorldDataVariants.SetBlockVariant("PALAAA00.RMB", variantNorthmoor, locNorthmoor);
            }       

            // Daenia (101) in region 41
            if (WorldDataVariants.GetBlockVariant("PALAAA02.RMB") == WorldDataVariants.NoVariant)
            {
                int locDaenia = WorldDataReplacement.MakeLocationKey(41, 101);
                WorldDataVariants.SetBlockVariant("PALAAA02.RMB", variantDaenia, locDaenia);
            }        

            // Ephesus (205) in region 53
            if (WorldDataVariants.GetBlockVariant("PALAAA00.RMB") == WorldDataVariants.NoVariant)
            {
                int locEphesus = WorldDataReplacement.MakeLocationKey(53, 205);
                WorldDataVariants.SetBlockVariant("PALAAA00.RMB", variantEphesus, locEphesus);
            } 

            // Merwark Hollow (613) in region 23
            if (WorldDataVariants.GetBlockVariant("PALAAA00.RMB") == WorldDataVariants.NoVariant)
            {
                int locMerwarkHollow = WorldDataReplacement.MakeLocationKey(23, 613);
                WorldDataVariants.SetBlockVariant("PALAAA00.RMB", variantMerwarkHollow, locMerwarkHollow);
            }   

            // Wayrest (601) in region 23
            if (WorldDataVariants.GetBuildingVariant(23, 601, "MAGEAA08.RMB", 0) == WorldDataVariants.NoVariant)
            {
                int locWayrest = WorldDataReplacement.MakeLocationKey(23, 601);
                WorldDataVariants.SetBuildingVariant("MAGEAA08.RMB", 0, variantWayrest, locWayrest);
            }   

            // Daggerfall (1231) in region 17
            if (WorldDataVariants.GetBuildingVariant(17, 1231, "DARKAA01.RMB", 0) == WorldDataVariants.NoVariant)
            {
                int locDaggerfall = WorldDataReplacement.MakeLocationKey(17, 1231);
                WorldDataVariants.SetBuildingVariant("DARKAA01.RMB", 0, variantDaggerfall, locDaggerfall);
            }  

            // The Unfortunate Goblin Pub (3) in region 1
            if (WorldDataVariants.GetBuildingVariant(1, 3, "TVRNAS05.RMB", 0) == WorldDataVariants.NoVariant)
            {
                int locDragontail = WorldDataReplacement.MakeLocationKey(1, 3);
                WorldDataVariants.SetBuildingVariant("TVRNAS05.RMB", 0, variantDragontail, locDragontail);
            }                         
        }
        
    }
}
