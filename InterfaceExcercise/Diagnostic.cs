﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExcercise {
	class Diagnostic: Iprint, IWrite {


		public void Write(string s) {

		}

		public void Print(string s) {
			System.Diagnostics.Debug.WriteLine(s);
		}

		public void PrintAll(string[] strings) {
			foreach(string str in strings) {
				Print(str);
			};
		}

		public void Test() {
			throw new NotImplementedException();
		}
	}
}
