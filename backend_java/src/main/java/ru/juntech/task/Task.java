package ru.juntech.task;

import ru.juntech.directions.DirectionAble;
import ru.juntech.student.StudentDirection;

public class Task {
    DirectionAble directionAble;

    public void taskSolving(StudentDirection direction, double score) {
        DirectionAble dir = direction.getDirection();
        dir.setPriority(score);
    }
}
