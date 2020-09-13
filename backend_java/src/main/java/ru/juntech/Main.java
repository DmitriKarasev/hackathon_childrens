package ru.juntech;

import ru.juntech.student.*;
import ru.juntech.student.impl.Student;
import ru.juntech.student.StudentData;
import ru.juntech.task.Task;

public class Main {
    public static void main(String[] args) {
        StudentData appData = new StudentData();
        Task task = new Task();
        StudentsFactory studentsFactory = Student::new;
        Student app1 = studentsFactory.create("Ivan", "Ivanov", 15);
        Student app2 = studentsFactory.create("Alex", "Smith", 14);

        StudentDirection stDir1 = appData.setFirstDirection(app1);
        StudentDirection stDir2 = appData.setFirstDirection(app2);
        task.taskSolving(stDir1, 3);
        task.taskSolving(stDir2, 6);
        System.out.println(stDir1.toString());
        System.out.println(stDir2.toString());
    }
}
