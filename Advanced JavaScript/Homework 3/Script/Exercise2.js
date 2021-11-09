$(document).ready(function(){
    $.ajax({
        url: "https://raw.githubusercontent.com/sedc-codecademy/skwd9-04-ajs/main/Samples/students_v2.json",
        success: function(result){
            let data = JSON.parse(result);
            // console.log(data);
            console.log("All students with an average grade higher than 3");
            let averageGradeHigherThan3 = data.filter(grades => grades.averageGrade > 3);
            console.log(averageGradeHigherThan3);
            
            console.log("All female student names with an average grade of 5");
            let arrFemale = data.filter(female => female.gender == "Female");
            let averageGradeOf5 = arrFemale.filter(grade => grade.averageGrade == 5);
            // console.log(averageGradeOf5);
            for (let i = 0; i < averageGradeOf5.length; i++){
                console.log(averageGradeOf5[i].firstName);
            }

            console.log("All male student full names who live in Skopje and are over 18 years old");
            let maleStudent = data.filter(male => male.gender == "Male");
            let liveInSkopje = maleStudent.filter(live => live.city == "Skopje");
            let over18 = liveInSkopje.filter(ages => ages.age > 18);
            for (let i = 0; i < over18.length; i++){
                console.log(over18[i].firstName + " " + over18[i].lastName);
            }

            console.log("The average grades of all female students over the age of 24");
            let over24 = arrFemale.filter(ages => ages.age > 24);
            let average = 0;
            for (let i = 0; i < over24.length; i++){
                average += over24[i].averageGrade / over24.length;
            }
            console.log(average);

            console.log("All male students with a name starting with B and average grade over 2");
            let averageGradeOver2 = maleStudent.filter(grades => grades.averageGrade > 2);
            for (let i = 0; i < averageGradeOver2.length; i++){
                let letter = averageGradeOver2[i].firstName[0];
                // console.log(letter);
                if(letter == "B"){
                    console.log(averageGradeOver2[i].firstName);
                }
            }



        },
        error: function(err){
            console.log(err);
        }
    });
});