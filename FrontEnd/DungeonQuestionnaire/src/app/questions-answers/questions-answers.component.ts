import { Component, OnInit } from '@angular/core';
import { FrontEndService } from '../Services/front-end.service';
import { Question } from '../models/question.model';

@Component({
  selector: 'app-questions-answers',
  templateUrl: './questions-answers.component.html',
  styleUrls: ['./questions-answers.component.css']
})
export class QuestionsAnswersComponent implements OnInit {
    question:string = "(Question)";
    answer1:string = "answer";
    answer2:string = "answer";
    answer3:string = "answer";
    answer4:string = "answer";
    correctAnswer:string = "Correct answer";
    questionAttack:number = 0;
    listOfQuestion:Question[];
    randomNumber:number = 0;

  constructor(private frontEndServ: FrontEndService) { 
    this.listOfQuestion = [];
  }

  ngOnInit(): void {
    
    this.frontEndServ.getAllQuestions().subscribe(result => 
      {
      this.listOfQuestion = result;
      this.changeQuestionsAndAnswers(0);
    }
    )}

   
  
  

  getRandomNumber(max:number) : number {
    this.randomNumber = Math.floor((Math.random() * max))
    return this.randomNumber;
};      

  // console.log(listOfQuestion);

  changeQuestionsAndAnswers(rand:number): void{

    rand = this.getRandomNumber(80);
    this.question = this.listOfQuestion[rand].questions;
    this.answer1 = this.listOfQuestion[rand].answer1;
    this.answer2 = this.listOfQuestion[rand].answer2;
    this.answer3 = this.listOfQuestion[rand].answer3;
    this.answer4 = this.listOfQuestion[rand].answer4;
    this.correctAnswer = this.listOfQuestion[rand].correctAnswer;
    this.questionAttack = this.listOfQuestion[rand].damageValue;

    
  }

}

// We will need to pull a random question with its answers and the correct answer from the database
// we will need to assign the correct answer to a local variable


// We will need to compare the selected question with the (correctanswer) from the database -- 
// if true, we will need to decrease enemyhp which is stored as a variable by the question value and show the user they got it correct
//        will need a check to see if enemy is defeated

//             if enemy is defeated, increase (enemycurrentlyfighting) in the database by 1 and pull the enemy data for that new id
//                 if no new enemy is found, show winner route

// if false, we will need to decrease player hp (update database too) by enemy attack value and provide the correct answer to the user
//         will need a check to see if player is defeated
// submit button will need to change to "next question" or display a next question link
// after submit button is clicked, we will need to display next question and set of answers and do this again. 
// need a boolean for a while statement (whileplaying) to loop through this while player is playing
// need a (click) for the button to do the check and display based on an if>then

// Need a (click) to move to the next question
// will need enemy data stored to local variables
// will need enemycurrentlyfighting to update when enemy is defeated