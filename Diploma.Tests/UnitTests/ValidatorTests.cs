using System;
using System.Collections.Generic;
using System.Text;
using Diploma.Models;
using Diploma.Validators;
using Xunit;
using FluentAssertions;

namespace Diploma.Tests.UnitTests
{
    public class ValidatorTests
    {
        [Fact]
        public void Validator_NullStudentModel_False()
        {
            var student = new StudentModel();

            Validator validator = new Validator();

            var act = validator.ValidateStudentRecord(student);

            act.Should().BeFalse();
        }

        [Fact]
        public void Validator_ValidStudentModel_True()
        {
            var student = new StudentModel();
            student.LastName = "petrov";
            student.FirstName = "peteya";
            List<Subject> Grades = new List<Subject>();
            Subject sbj = new Subject();
            sbj.SubjectName = "lang";
            sbj.Grade = 10;
            Grades.Add(sbj);          
            student.Grades = Grades;

            Validator validator = new Validator();

            var act = validator.ValidateStudentRecord(student);

            act.Should().BeTrue();
        }

        [Fact]
        public void Validator_GradeNotInRange_False()
        {
            var student = new StudentModel();
            student.LastName = "petrov";
            student.FirstName = "peteya";
            List<Subject> Grades = new List<Subject>();
            Subject sbj = new Subject();
            sbj.SubjectName = "lang";
            sbj.Grade = -10;
            Grades.Add(sbj);
            student.Grades = Grades;

            Validator validator = new Validator();

            var act = validator.ValidateStudentRecord(student);

            act.Should().BeFalse();
        }

        [Fact]
        public void Validator_NullFirstName_False()
        {
            var student = new StudentModel();
            student.LastName = "petrov";
            student.FirstName = null;
            List<Subject> Grades = new List<Subject>();
            Subject sbj = new Subject();
            sbj.SubjectName = "lang";
            sbj.Grade = 10;
            Grades.Add(sbj);
            student.Grades = Grades;

            Validator validator = new Validator();

            var act = validator.ValidateStudentRecord(student);

            act.Should().BeFalse();
        }

        [Fact]
        public void Validator_NullLastName_False()
        {
            var student = new StudentModel();
            student.LastName = null;
            student.FirstName = "peteya";
            List<Subject> Grades = new List<Subject>();
            Subject sbj = new Subject();
            sbj.SubjectName = "lang";
            sbj.Grade = 10;
            Grades.Add(sbj);
            student.Grades = Grades;

            Validator validator = new Validator();

            var act = validator.ValidateStudentRecord(student);

            act.Should().BeFalse();
        }
    }
}
