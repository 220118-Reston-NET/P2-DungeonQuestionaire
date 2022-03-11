import { Component, OnInit } from '@angular/core';
import { FrontEndService } from '../Services/front-end.service';
import { Question } from '../models/question.model';

@Component({
  selector: 'app-questions-answers',
  templateUrl: './questions-answers.component.html',
  styleUrls: ['./questions-answers.component.css']
})
export class QuestionsAnswersComponent implements OnInit {
    question:string = "(Question) loremipsumloremi psumloremipsumloremips umloremipsum loremipsum";
    answer1:string = "loremipsum loremipsum loremipsum loremipsum loremipsum loremipsum";
    answer2:string = "loremipsum loremipsum loremipsum loremipsum loremipsum loremipsum";
    answer3:string = "loremipsum loremipsum loremipsum loremipsum loremipsum loremipsum";
    answer4:string = "loremipsum loremipsum loremipsum loremipsum loremipsum loremipsum";
    questionAttack:number = 0;
    
    listOfQuestion:Question[];

  constructor(private frontEndServ: FrontEndService) { 
    this.listOfQuestion = [];
  }

  ngOnInit(): void {
    
    this.frontEndServ.getAllQuestions().subscribe(result => 
      {
      this.listOfQuestion = result;
    }
    )}

  changeQuestionsAndAnswers(): void {


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