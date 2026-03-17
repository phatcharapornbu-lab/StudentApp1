นางสาวภัทชราพร บุปผาสิงห์ 683450059-3
+----------------------+
|       Student        |
+----------------------+
| - Name : string      |
| - StudentID : string |
| - Score : int        |
+----------------------+
| + GetGrade() : string|
+----------------------+

            ▲
            |
            | (มีหลายคน)
            |
+-----------------------------+
|           Course            |
+-----------------------------+
| - CourseName : string       |
| - CourseID : string         |
| - Students : List<Student>  |
+-----------------------------+
| + AddStudent(s: Student)    |
| + GetMaxScore() : int       |
| + GetMinScore() : int       |
| + GetAverageScore() : double|
| + ShowStudents() : void     |
+-----------------------------+

            ▲
            |
            |
+----------------------+
|       Program        |
+----------------------+
| + Main() : void      |
+----------------------+
