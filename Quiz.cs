using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
	class Quiz
	{
		private string[,] questions = new string[20, 5];
		public Quiz()
		{
			questions[0, 0] = "How to remove borders applied in Cells? ";
			questions[0, 1] = "Select None on Border tab of Format cells";
			questions[0, 2] = "Open the list on Border tool in Format Cell toolbar then choose first tool (none)";
			questions[0, 3] = "Both of above";
			questions[0, 4] = "*None of above";
			//
			questions[1, 0] = "A computer cannot boot if it does not have the _____";
			questions[1, 1] = "Compiler";
			questions[1, 2] = "Loader";
			questions[1, 3] = "* Operating system";
			questions[1, 4] = "Assembler";
			//
			questions[2, 0] = "Junk e-mail is also called ______";
			questions[2, 1] = "*Spam";
			questions[2, 2] = "Spoof";
			questions[2, 3] = "Sniffer script";
			questions[2, 4] = "Spool";
			//
			questions[3, 0] = "The 2002 Commonwealth Games were held in";
			questions[3, 1] = "*UK";
			questions[3, 2] = "Canada";
			questions[3, 3] = "Australia";
			questions[3, 4] = "Malaysia";
			//
			questions[4, 0] = "The 2012 Olympics Games were held in";
			questions[4, 1] = "New York";
			questions[4, 2] = "Seul";
			questions[4, 3] = "*London";
			questions[4, 4] = "Tokyo";
			//
			questions[5, 0] = "By default, your documents print in ________ mode";
			questions[5, 1] = "Landscape";
			questions[5, 2] = "*Portrait";
			questions[5, 3] = "Page Setup";
			questions[5, 4] = "Print View";
			//
			questions[6, 0] = "Pythagoras was first to ____ the universal validity of geometrical theorem.";
			questions[6, 1] = "Give";
			questions[6, 2] = "*Prove";
			questions[6, 3] = "Both";
			questions[6, 4] = "None of the above";
			//
			questions[7, 0] = "Sulphur is not present in";
			questions[7, 1] = "Iron Pyrites";
			questions[7, 2] = "Gypsum";
			questions[7, 3] = "Coal";
			questions[7, 4] = "*Chlorapatite";
			//
			questions[8, 0] = "Oscar Awards were instituted in";
			questions[8, 1] = "1968";
			questions[8, 2] = "1901";
			questions[8, 3] = "1965";
			questions[8, 4] = "*1929";
			//
			questions[9, 0] = "Sculpture flourished during";
			questions[9, 1] = "*Indus valley civilization";
			questions[9, 2] = "Egyptian civilization";
			questions[9, 3] = "Chinese civilization";
			questions[9, 4] = "None of the above";
			//
			questions[10, 0] = "Penicillin is widely used as";
			questions[10, 1] = "An Insecticide";
			questions[10, 2] = "An Antiseptic";
			questions[10, 3] = "A Disinfectant";
			questions[10, 4] = "*An Antibiotic";
		}
		public string getQuestion(int i)
		{
			return questions[i, 0];
		}
		public string getAnswer(int i, int j)
		{
			return questions[i, j];
		}

	}
}
