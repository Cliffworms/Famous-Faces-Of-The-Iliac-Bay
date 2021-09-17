// Project:         Famous Faces of the Iliac Bay for Daggerfall Unity (http://www.dfworkshop.net)
// Copyright:       Copyright (C) 2021 Cliffworms
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Author:          Hazelnut & Cliffworms

using System;
using UnityEngine;
using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Game.Serialization;
using DaggerfallWorkshop.Game.Utility;
using DaggerfallWorkshop.Game.Utility.ModSupport;
using DaggerfallWorkshop.Utility.AssetInjection;

namespace FamousFacesOfTheIliacBay
{
    public class FamousFacesOfTheIliacBayMod : MonoBehaviour
    {
        private const string variantLainlyn = "_lainlyn";
        private const string variantAnticlere = "_anticlere";
        private const string variantYkalon = "_ykalon";
        private const string variantGlenpoint = "_glenpoint";
        private const string variantGraymore = "_graymore";
        private const string variantBubissidata = "_bubissidata";
        private const string variantRipfort = "_ripfort";
        private const string variantHebu = "_hebu";
        private const string variantNorthmoor = "_northmoor";
        private const string variantDaenia = "_daenia";
        private const string variantEphesus = "_ephesus";
        private const string variantIlessanHills = "_ilessanhills";
        private const string variantKambria = "_kambria";
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

        static Mod mod;

        [Invoke(StateManager.StateTypes.Start, 0)]
        public static void Init(InitParams initParams)
        {
            mod = initParams.Mod;
            var go = new GameObject(mod.Title);
            go.AddComponent<FamousFacesOfTheIliacBayMod>();
        }

        void Awake()
        {
            Debug.Log("Begin mod init: FamousFacesOfTheIliacBay");

            SaveLoadManager.OnLoad += SaveLoadManager_OnLoad;
            StartGameBehaviour.OnStartGame += StartGameBehaviour_OnStartGame;

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
            if (WorldDataVariants.GetBuildingVariant(22, 161, "TEMPAAH0.RMB", 0) == null)
            {
                int locHebu = WorldDataReplacement.MakeLocationKey(22, 161);
                WorldDataVariants.SetBuildingVariant("TEMPAAH0.RMB", 0, variantHebu, locHebu);
            }  

            // Abibon-gora (78) in region 43
            if (WorldDataVariants.GetBuildingVariant(43, 78, "PALAGA01.RMB", 0) == null)
            {
                int locAbibonGora = WorldDataReplacement.MakeLocationKey(43, 78);
                WorldDataVariants.SetBuildingVariant("PALAGA01.RMB", 0, variantAbibonGora, locAbibonGora);
            }                                

            // Anticlere (600) in region 21
            if (WorldDataVariants.GetBuildingVariant(21, 600, "PALAAA02.RMB", 0) == null)
            {
                int locAnticlere = WorldDataReplacement.MakeLocationKey(21, 600);
                WorldDataVariants.SetBuildingVariant("PALAAA02.RMB", 0, variantAnticlere, locAnticlere);
                WorldDataVariants.SetBuildingVariant("THIEAL00.RMB", 0, variantAnticlere, locAnticlere);
                WorldDataVariants.SetBuildingVariant("TEMPAAC0.RMB", 0, variantAnticlere, locAnticlere);
            }

            // Bubissidata (2) in region 20
            if (WorldDataVariants.GetBuildingVariant(20, 2, "THIEAL00.RMB", 0) == null)
            {
                int locBubissidata = WorldDataReplacement.MakeLocationKey(20, 2);
                WorldDataVariants.SetBuildingVariant("THIEAL00.RMB", 0, variantBubissidata, locBubissidata);
            }

            // Pothago (6) in region 45
            if (WorldDataVariants.GetBuildingVariant(45, 6, "PALAGA01.RMB", 0) == null)
            {
                int locPothago = WorldDataReplacement.MakeLocationKey(45, 6);
                WorldDataVariants.SetBuildingVariant("PALAGA01.RMB", 0, variantPothago, locPothago);
            } 

            // Kairou (97) in region 44
            if (WorldDataVariants.GetBuildingVariant(44, 97, "PALAGA04.RMB", 0) == null)
            {
                int locKairou = WorldDataReplacement.MakeLocationKey(44, 97);
                WorldDataVariants.SetBuildingVariant("PALAGA04.RMB", 0, variantKairou, locKairou);
            } 

            // Tulune (59) in region 58
            if (WorldDataVariants.GetBuildingVariant(58, 59, "PALAAA02.RMB", 0) == null)
            {
                int locTulune = WorldDataReplacement.MakeLocationKey(58, 59);
                WorldDataVariants.SetBuildingVariant("PALAAA02.RMB", 0, variantTulune, locTulune);
            }  

            // Totambu (633) in region 51
            if (WorldDataVariants.GetBuildingVariant(51, 633, "PALAAA02.RMB", 0) == null)
            {
                int locTotambu = WorldDataReplacement.MakeLocationKey(51, 633);
                WorldDataVariants.SetBuildingVariant("PALAAA02.RMB", 0, variantTotambu, locTotambu);
            }  

            // Tigonus (54) in region 48
            if (WorldDataVariants.GetBuildingVariant(48, 54, "PALAAA02.RMB", 0) == null)
            {
                int locTigonus = WorldDataReplacement.MakeLocationKey(48, 54);
                WorldDataVariants.SetBuildingVariant("PALAAA02.RMB", 0, variantTigonus, locTigonus);
            } 

            // Shalgora (161) in region 42
            if (WorldDataVariants.GetBuildingVariant(42, 161, "PALAAA02.RMB", 0) == null)
            {
                int locShalgora = WorldDataReplacement.MakeLocationKey(42, 161);
                WorldDataVariants.SetBuildingVariant("PALAAA02.RMB", 0, variantShalgora, locShalgora);
            }  

            // Glenumbra (94) in region 59
            if (WorldDataVariants.GetBuildingVariant(59, 94, "PALAAA02.RMB", 0) == null)
            {
                int locGlenumbra = WorldDataReplacement.MakeLocationKey(59, 94);
                WorldDataVariants.SetBuildingVariant("PALAAA02.RMB", 0, variantGlenumbra, locGlenumbra);
            }  

            // Gavaudon (24) in region 57
            if (WorldDataVariants.GetBuildingVariant(57, 24, "PALAAA02.RMB", 0) == null)
            {
                int locGavaudon = WorldDataReplacement.MakeLocationKey(57, 24);
                WorldDataVariants.SetBuildingVariant("PALAAA02.RMB", 0, variantGavaudon, locGavaudon);
            }      

            // Dwynnen (522) in region 5
            if (WorldDataVariants.GetBuildingVariant(5, 522, "PALAAA02.RMB", 0) == null)
            {
                int locDwynnen = WorldDataReplacement.MakeLocationKey(5, 522);
                WorldDataVariants.SetBuildingVariant("PALAAA02.RMB", 0, variantDwynnen, locDwynnen);
            } 

            // Alcaire (57) in region 34
            if (WorldDataVariants.GetBuildingVariant(34, 57, "PALAAA02.RMB", 0) == null)
            {
                int locAlcaire = WorldDataReplacement.MakeLocationKey(34, 57);
                WorldDataVariants.SetBuildingVariant("PALAAA02.RMB", 0, variantAlcaire, locAlcaire);
            }  

            // Satakalaam (90) in region 50
            if (WorldDataVariants.GetBuildingVariant(50, 90, "PALAAA01.RMB", 0) == null)
            {
                int locSatakalaam = WorldDataReplacement.MakeLocationKey(50, 90);
                WorldDataVariants.SetBuildingVariant("PALAAA01.RMB", 0, variantSatakalaam, locSatakalaam);
            }  

            // Bhoriane (115) in region 36
            if (WorldDataVariants.GetBuildingVariant(36, 115, "PALAAA01.RMB", 0) == null)
            {
                int locBhoriane = WorldDataReplacement.MakeLocationKey(36, 115);
                WorldDataVariants.SetBuildingVariant("PALAAA01.RMB", 0, variantBhoriane, locBhoriane);
            }      

            // Urvaius (263) in region 39
            if (WorldDataVariants.GetBuildingVariant(39, 263, "PALAAA00.RMB", 0) == null)
            {
                int locUrvaius = WorldDataReplacement.MakeLocationKey(39, 263);
                WorldDataVariants.SetBuildingVariant("PALAAA00.RMB", 0, variantUrvaius, locUrvaius);
            }

            // Santaki (26) in region 54
            if (WorldDataVariants.GetBuildingVariant(54, 26, "PALAAA00.RMB", 0) == null)
            {
                int locSantaki = WorldDataReplacement.MakeLocationKey(54, 26);
                WorldDataVariants.SetBuildingVariant("PALAAA00.RMB", 0, variantSantaki, locSantaki);
            }    

            // Phrygias (167) in region 38
            if (WorldDataVariants.GetBuildingVariant(38, 167, "PALAAA00.RMB", 0) == null)
            {
                int locPhrygias = WorldDataReplacement.MakeLocationKey(38, 167);
                WorldDataVariants.SetBuildingVariant("PALAAA00.RMB", 0, variantPhrygias, locPhrygias);
            }    

            // Mournoth (201) in region 52
            if (WorldDataVariants.GetBuildingVariant(52, 201, "PALAAA00.RMB", 0) == null)
            {
                int locMournoth = WorldDataReplacement.MakeLocationKey(52, 201);
                WorldDataVariants.SetBuildingVariant("PALAAA00.RMB", 0, variantMournoth, locMournoth);
            } 

            // Menevia (114) in region 33
            if (WorldDataVariants.GetBuildingVariant(33, 114, "PALAAA00.RMB", 0) == null)
            {
                int locMenevia = WorldDataReplacement.MakeLocationKey(33, 114);
                WorldDataVariants.SetBuildingVariant("PALAAA00.RMB", 0, variantMenevia, locMenevia);
            }  

            // Kozanset (31) in region 49
            if (WorldDataVariants.GetBuildingVariant(49, 31, "PALAAA00.RMB", 0) == null)
            {
                int locKozanset = WorldDataReplacement.MakeLocationKey(49, 31);
                WorldDataVariants.SetBuildingVariant("PALAAA00.RMB", 0, variantKozanset, locKozanset);
            }   

            // Kambria (70) in region 37
            if (WorldDataVariants.GetBuildingVariant(37, 70, "PALAAA00.RMB", 0) == null)
            {
                int locKambria = WorldDataReplacement.MakeLocationKey(37, 70);
                WorldDataVariants.SetBuildingVariant("PALAAA00.RMB", 0, variantKambria, locKambria);
            }      

            // Ilessan Hills (344) in region 60
            if (WorldDataVariants.GetBuildingVariant(60, 344, "PALAAA01.RMB", 0) == null)
            {
                int locIlessanHills = WorldDataReplacement.MakeLocationKey(60, 344);
                WorldDataVariants.SetBuildingVariant("PALAAA01.RMB", 0, variantIlessanHills, locIlessanHills);
            }     

            // Lainlyn (103) in region 22
            if (WorldDataVariants.GetBuildingVariant(22, 103, "PALAAA00.RMB", 0) == null)
            {
                int locLainlyn = WorldDataReplacement.MakeLocationKey(22, 103);
                WorldDataVariants.SetBuildingVariant("PALAAA00.RMB", 0, variantLainlyn, locLainlyn);
            }                  

            // Ykalon (357) in region 40
            if (WorldDataVariants.GetBuildingVariant(40, 357, "PALAAA02.RMB", 0) == null)
            {
                int locYkalon = WorldDataReplacement.MakeLocationKey(40, 357);
                WorldDataVariants.SetBuildingVariant("PALAAA02.RMB", 0, variantYkalon, locYkalon);
            }    

            // Glenpoint (181) in region 18
            if (WorldDataVariants.GetBuildingVariant(18, 181, "PALAAA02.RMB", 0) == null)
            {
                int locGlenpoint = WorldDataReplacement.MakeLocationKey(18, 181);
                WorldDataVariants.SetBuildingVariant("PALAAA02.RMB", 0, variantGlenpoint, locGlenpoint);
            }   

            // Graymore (301) in region 18
            if (WorldDataVariants.GetBuildingVariant(18, 301, "THIEAM00.RMB", 0) == null)
            {
                int locGraymore = WorldDataReplacement.MakeLocationKey(18, 301);
                WorldDataVariants.SetBuildingVariant("THIEAM00.RMB", 0, variantGraymore, locGraymore);
            } 

            // Ripfort (410) in region 18
            if (WorldDataVariants.GetBuildingVariant(18, 410, "THIEAM00.RMB", 0) == null)
            {
                int locRipfort = WorldDataReplacement.MakeLocationKey(18, 410);
                WorldDataVariants.SetBuildingVariant("THIEAM00.RMB", 0, variantRipfort, locRipfort);
            }                 

            // Northmoor (252) in region 32
            if (WorldDataVariants.GetBuildingVariant(32, 252, "PALAAA00.RMB", 0) == null)
            {
                int locNorthmoor = WorldDataReplacement.MakeLocationKey(32, 252);
                WorldDataVariants.SetBuildingVariant("PALAAA00.RMB", 0, variantNorthmoor, locNorthmoor);
            }       

            // Daenia (101) in region 41
            if (WorldDataVariants.GetBuildingVariant(41, 101, "PALAAA02.RMB", 0) == null)
            {
                int locDaenia = WorldDataReplacement.MakeLocationKey(41, 101);
                WorldDataVariants.SetBuildingVariant("PALAAA02.RMB", 0, variantDaenia, locDaenia);
            }        

            // Ephesus (205) in region 53
            if (WorldDataVariants.GetBuildingVariant(53, 205, "PALAAA00.RMB", 0) == null)
            {
                int locEphesus = WorldDataReplacement.MakeLocationKey(53, 205);
                WorldDataVariants.SetBuildingVariant("PALAAA00.RMB", 0, variantEphesus, locEphesus);
            } 

            // Merwark Hollow (613) in region 23
            if (WorldDataVariants.GetBuildingVariant(23, 613, "PALAAA00.RMB", 0) == null)
            {
                int locMerwarkHollow = WorldDataReplacement.MakeLocationKey(23, 613);
                WorldDataVariants.SetBuildingVariant("PALAAA00.RMB", 0, variantMerwarkHollow, locMerwarkHollow);
            }                                                                                                
        }
    }
}
