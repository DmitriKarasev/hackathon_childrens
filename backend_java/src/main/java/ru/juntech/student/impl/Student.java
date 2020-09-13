package ru.juntech.student.impl;

import ru.juntech.directions.DirectionAble;

public class Student {
    private String name;
    private String lastName;
    private int age;
    private Student student;
    private DirectionAble direction;

    public Student(String name, String lastName, int age) {
        this.name = name;
        this.lastName = lastName;
        this.age = age;
    }

    public Student(Student student, DirectionAble direction) {
        this.student = student;
        this.direction = direction;
    }

    @Override
    public String toString() {
        return "name='" + name + '\'' +
                ", lastName='" + lastName + '\'' +
                ", age=" + age;
    }
}
