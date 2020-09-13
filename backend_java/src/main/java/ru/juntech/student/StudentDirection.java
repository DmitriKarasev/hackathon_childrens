package ru.juntech.student;

import ru.juntech.directions.DirectionAble;
import ru.juntech.student.impl.Student;

public class StudentDirection {
    private final Student student;
    private DirectionAble firstDirection;
    private DirectionAble secondDirection;

    public StudentDirection(Student student, DirectionAble direction) {
        this.student = student;
        this.firstDirection = direction;
    }

    public StudentDirection(Student student, DirectionAble firstDirection, DirectionAble direction2) {
        this.student = student;
        this.firstDirection = firstDirection;
        this.secondDirection = direction2;
    }

    public DirectionAble getDirection() {
        return firstDirection;
    }

    @Override
    public String toString() {
        return "StudentDirection{" +
                student + ", First direction: " + firstDirection +
                ", Second Direction: " + secondDirection +
                '}';
    }
}
