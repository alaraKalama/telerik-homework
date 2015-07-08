function solve() {
    var Course = {
        init: function(title, presentations) {
            validateTitle(title);
            this.title = title;
            validatePresentations(presentations);
            this.presentations = presentations;
            this.students = [];
            this.examResults = [];

            return this;

        },
        addStudent: function(name) {
            var names = name.split(' ');
            if(names.length > 2){
                errors.InvalidStudentName();
            }
            
            validateName(names[0]);
            validateName(names[1]);
            var student = {};
            student.firstname = names[0];
            student.lastname = names[1];
            var id = this.students.length + 1;
            student.id = id;
            this.students.push(student);
            return id;
        },
        getAllStudents: function() {
            return this.students.slice();
        },
        submitHomework: function(studentID, homeworkID) {
            validateId(studentID, 1, this.students.length);
            validateId(homeworkID, 1, this.presentations.length);
        },
        pushExamResults: function(results) {
            checkResults(results);
            //this.examResults=results;
            return this;
        },
        getTopStudents: function() {
        }
    };

    function checkResults(results){
        if(results.length<1){
            Err('emptyArray');
        }
        var usedIds=[];
        var max=this.students[this.students.length];
        for(var k in results){
            var studentID=results[k].StudentID;
            var score=results[k].score;
            if (studentID > max || studentID < 1 && usedIds.indexOf(studentID)===-1) {
                Err('invalid stundent id');
            }
            if(!isNaN(score)){
                Err('Invalid Score');
            }
        }
    }

    Object.defineProperty(Course, 'title', {
        get : function(){
            return Course._title;
        },
        set : function(value){
            Course._title = value;
        }
    });

    Object.defineProperty(Course, 'presentations', {
        get: function () {
            return Course._presentations;
        },
        set: function(presentations){
            Course._presentations = presentations;
        }
    });

    Object.defineProperty(Course, 'students', {
        get: function () {
            return Course._students;
        },
        set: function(students){
            Course._students = students;
        }
    });
        
    errors = {
        InvalidTypeTitle : function () {
            throw new Error('Invalid type of title.');
        },
        InvalidInputTitle : function(){
            throw new Error('Titles do not start or end with spaces. Titles do not have consecutive spaces. Titles have at least one character');
        },
        InvalidPresentationsInput: function(){
            throw new Error('Presentations cannot be an empty string');
        },
        InvalidStudentName: function(){
            throw new Error('Invalid student name. Names start with an upper case letter. All other symbols in the name (if any) are lowercase letters');
        },
        InvalidResults: function(){
            throw new Error('A problem with the results');
        }
    };

    //validating functions:
    function validateTitle (title) {
        if(title.length < 1){
            errors.InvalidTypeTitle();
        }
        if(title === null || typeof title !== 'string'){
            errors.InvalidInputTitle();
        }

        if(title.trim() === '' || title !== title.trim()){
           errors.InvalidInputTitle();
        }
        if(/[\s]{2,}/.test(title)){
            errors.InvalidInputTitle();
        }
    }
    function validatePresentations(presentations){
        if(presentations.length < 1 ){
            errors.InvalidPresentationsInput();
        }
        for(var i in presentations){
            validateTitle(presentations[i]);
        }
    }
    function validateName(name){

        if(typeof name !== 'string' || name === null){
            errors.InvalidStudentName();
        }

        var symbol;
        for(var i = 0; len = name.length; i < len, i += 1){
            symbol = name.charAt(i);
            if(i === 0){
                if(!isUppercase(symbol)){
                    errors.InvalidStudentName();
                }
            }
            else{
                if(isUppercase(symbol)){
                    errors.InvalidStudentName();
                }
            }
            return true;
        }
    }
    function validateId(id, min, max){
        if(id != Number(id)){
            throw 'Invalid type for id.';
        }

        id = +id;

        if(id < min || id > max){
            throw 'Invalid range.';
        }
    }

    function createStudent(firstname, lastname){
        return {
            firstname: firstname,
            lastname: lastname
        };

    }
    function isUppercase(letter) {
        return letter === letter.toUpperCase();
    }

    return Course;
}

module.exports = solve;
