package ru.juntech.student;

import ru.juntech.directions.impl.NanoQuantum;
import ru.juntech.student.impl.Student;
import ru.juntech.directions.DirectionAble;
import ru.juntech.directions.impl.ITQuantum;

import java.util.Scanner;

public class StudentData {
    private static final Scanner scanner = new Scanner(System.in);
    private DirectionAble directionAble;

    public StudentDirection setFirstDirection(Student student) {
        System.out.println("Please, choose direction.\n" +
                "1 - IT Quantum.\n" +
                "2 - Nano Quantum.");
        int direction = scanner.nextInt();

        if (direction == 1) {
            directionAble = new ITQuantum();
            return directionAble.addDirection(student);
        } else if (direction == 2) {
            directionAble = new NanoQuantum();
            return directionAble.addDirection(student);
        }
        return null;
    }
}
