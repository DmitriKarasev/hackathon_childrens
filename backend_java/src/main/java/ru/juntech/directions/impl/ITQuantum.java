package ru.juntech.directions.impl;

import ru.juntech.student.StudentDirection;
import ru.juntech.student.impl.Student;
import ru.juntech.directions.DirectionAble;

public class ITQuantum implements DirectionAble {
    private double priority = 0;

    @Override
    public StudentDirection addDirection(Student student) {
        return new StudentDirection(student, new ITQuantum());
    }

    @Override
    public void setPriority(double score) {
        this.priority += score;
    }

    @Override
    public double getPriority(double score) {
        return this.priority;
    }

    @Override
    public String toString() {
        return "ITQuantum{" +
                "priority=" + priority +
                '}';
    }
}
