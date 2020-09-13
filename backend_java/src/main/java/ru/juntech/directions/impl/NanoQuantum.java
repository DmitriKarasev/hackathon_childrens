package ru.juntech.directions.impl;

import ru.juntech.directions.DirectionAble;
import ru.juntech.student.StudentDirection;
import ru.juntech.student.impl.Student;

public class NanoQuantum implements DirectionAble {
    private DirectionAble directionAble;
    private double priority = 0;

    @Override
    public StudentDirection addDirection(Student student) {
        return new StudentDirection(student, new ITQuantum());
    }

    @Override
    public void setPriority(double score) {

    }

    @Override
    public double getPriority(double score) {
        return this.priority;
    }

    @Override
    public String toString() {
        return "NanoQuantum";
    }
}
