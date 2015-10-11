using System;
using System.Data.SQLite;

namespace CW_Study_Tool_4
{
    internal class Gib
    {
        public static string compath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\CW Soft";
        public static string hostpath = compath + "\\CW Study Tool 4";
        public static string dbpath = hostpath + "\\CWStudyTool4.db";

        public static SQLiteConnection con = null;
        
        // OLD
        public static string frmlearntext;

        public static int studymode;
        /*
         * 1 : Learn New
         * 2 : Review Old
         * 3 : Hard Words
         * 4 : Check Words
         * 5 : Word Game
         * 6 : Review Game
        */

        public static int cstn;
        public static string[] cst1 = new string[10000];
        public static string[] cst2 = new string[10000];
        public static int[] cst3 = new int[10000];

        public static int today, beginday;

        public static int nowword;

        public static int checkday;

        public static bool dosearch;
        public static string searchword;
    }
}
/*
 * 0 1 2 4 7 15
 * 
 * 
 * cst1 : Word
 * cst2 : Translation
 * cst3 : Add Date
*/
