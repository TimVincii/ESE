using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESE
{
    /// <summary>
    /// This class houses an array containing the key names of values that are necessary
    /// for ESE to function.
    /// </summary>
    public class KeyRegistry
    {
        public static string[] keys = new string[] {"DesiredScreenHeight",                          //0
                                                    "DesiredScreenWidth",                           //1
                                                    "DisplayGamma",                                 //2
                                                    "FrameRateLimit",                               //3
                                                    "FullscreenMode",                               //4
                                                    "LastConfirmedFullscreenMode",                  //5
                                                    "LastUserConfirmedDesiredScreenHeight",         //6
                                                    "LastUserConfirmedDesiredScreenWidth",          //7
                                                    "LastUserConfirmedResolutionSizeX",             //8
                                                    "LastUserConfirmedResolutionSizeY",             //9
                                                    "MeshQuality",                                  //10
                                                    "PreferredFeatureLevel",                        //11
                                                    "PreferredFullscreenMode",                      //12
                                                    "ResolutionSizeX",                              //13
                                                    "ResolutionSizeY",                              //14
                                                    "UserInterfaceContrast",                        //15
                                                    "bShowFPS",                                     //16
                                                    "bUseVSync",                                    //17
                                                    "sg.FoliageQuality",                            //18
                                                    "sg.ResolutionQuality",                         //19
                                                    "sg.TextureQuality",                            //20
                                                    "sg.ViewDistanceQuality"};                      //21

        public static string[] IntegerKeys = new string[] {"DesiredScreenHeight",                   //0
                                                           "DesiredScreenWidth",                    //1
                                                           "FullscreenMode",                        //2
                                                           "LastConfirmedFullscreenMode",           //3
                                                           "LastUserConfirmedDesiredScreenHeight",  //4
                                                           "LastUserConfirmedDesiredScreenWidth",   //5
                                                           "LastUserConfirmedResolutionSizeX",      //6
                                                           "LastUserConfirmedResolutionSizeY",      //7
                                                           "MeshQuality",                           //8
                                                           "PreferredFullscreenMode",               //9
                                                           "ResolutionSizeX",                       //10
                                                           "ResolutionSizeY",                       //11
                                                           "sg.FoliageQuality",                     //12
                                                           "sg.ResolutionQuality",                  //13
                                                           "sg.TextureQuality",                     //14
                                                           "sg.ViewDistanceQuality"};               //15

        public static string[] FloatingKeys = new string[] {"DisplayGamma",                         //0
                                                         "FrameRateLimit",                          //1
                                                         "UserInterfaceContrast"};                  //2

        public static string[] BooleanKeys = new string[] {"bShowFPS",                              //0
                                                           "bUseVSync"};                            //1
    }
}
