﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DS.Projeto.View {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var main = new frmMain();
			Application.Run(main);
		}
	}
}
