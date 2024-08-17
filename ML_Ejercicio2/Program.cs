// https://learn.microsoft.com/es-es/training/modules/challenge-project-arrays-iteration-selection/2-prepare


/* 
Esta aplicación de consola C# está diseñada para:
- Utilizar matrices para almacenar los nombres de los estudiantes y las calificaciones de las tareas.
- Utilizar una declaración `foreach` para iterar a través de los nombres de los estudiantes como un bucle de programa externo.
- Utilizar una declaración `if` dentro del bucle externo para identificar el nombre del estudiante actual y acceder a las calificaciones de las tareas de ese estudiante.
- Utilizar una declaración `foreach` dentro del bucle externo para iterar a través de la matriz de calificaciones de las tareas y sumar los valores.
- Utilizar un algoritmo dentro del bucle externo para calcular la calificación promedio del examen para cada estudiante.
- Utilizar una construcción `if-elseif-else` dentro del bucle externo para evaluar la calificación promedio del examen y asignar una calificación con letras automáticamente.
- Integrar las calificaciones de créditos adicionales al calcular la calificación final y la calificación con letras del estudiante de la siguiente manera:
- Detecta las asignaciones de créditos adicionales en función de la cantidad de elementos en la matriz de calificaciones del estudiante.
- Divide los valores de las asignaciones de créditos adicionales por 10 antes de agregar las calificaciones de créditos adicionales a la suma de las calificaciones de los exámenes.
- Utilizar el siguiente formato de informe para informar las calificaciones de los estudiantes:

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
//Console.Clear();
Console.WriteLine("Student\t\tGrade\tLetter Grade\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumAssignmentScores = 0;

    decimal currentStudentGrade = 0;

    int gradedAssignments = 0;

    /* 
    the inner foreach loop sums assignment scores
    extra credit assignments are worth 10% of an exam score
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;

        else
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    // Student         Grade
    // Sophia:         92.2    A-
    
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Son las 23H00");
// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
