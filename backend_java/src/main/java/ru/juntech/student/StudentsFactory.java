package ru.juntech.student;

import ru.juntech.student.impl.Student;

public interface StudentsFactory {
    Student create(String name, String lastName, int age);
}
