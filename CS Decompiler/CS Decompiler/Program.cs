﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mono;
using Mono.Cecil;
using Mono.Cecil.Cil;
using ICSharpCode;
using System.IO;
using System.Net;
using System.Reflection;
using System.Diagnostics;

namespace CS_Decompiler
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Load());
        }
    }
}
