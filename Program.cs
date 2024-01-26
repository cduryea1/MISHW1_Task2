//Mis 3033
//Camille Duryea
//Task 2
//113529005

double totalGrade = 0.0;
string message = "";
int numOfExams = 3;
for (int i=0; i < numOfExams;i++)
{
    message = string.Format("Input Exam {0}: ", i + 1);
    Console.Write(message);
    string examGradeStr = Console.ReadLine();
    double examGradeDbl = Convert.ToDouble(examGradeStr);
    totalGrade = totalGrade + examGradeDbl;
    //totalGrade += examGradeDbl;
}
double avgGrade = totalGrade / numOfExams;
double avgGradePercent = avgGrade / 100.0;
message = String.Format("The final grade percent is {0:P2}", avgGradePercent);
Console.WriteLine(message);

Console.ReadKey();