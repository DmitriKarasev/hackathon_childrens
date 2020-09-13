package ru.juntech.directions;

import ru.juntech.student.StudentDirection;
import ru.juntech.student.impl.Student;

public interface DirectionAble {
    StudentDirection addDirection (Student student);

    void setPriority(double score);

    double getPriority(double score);
}
