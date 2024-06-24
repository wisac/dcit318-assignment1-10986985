using Grade_Calculator;

// Take score from user
double score = GradeCalculator.TakeInput();

// Calculate grade of score
string grade = GradeCalculator.CalculateGrade(score);

// Display Grade information
Console.WriteLine(grade);
