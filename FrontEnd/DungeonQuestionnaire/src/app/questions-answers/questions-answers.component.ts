import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FrontEndService } from '../Services/front-end.service';
import { Question } from '../models/question.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-questions-answers',
  templateUrl: './questions-answers.component.html',
  styleUrls: ['./questions-answers.component.css']
})
export class QuestionsAnswersComponent implements OnInit {
    question:string = "";
    answer1:string = "";
    answer2:string = "";
    answer3:string = "";
    answer4:string = "";
    correctAnswer:string = "Correct Answer ";
    questionAttack:number = 0;
    listOfQuestion:Question[];
    randomNumber:number = 0;
    currentEnemyHP: number = 0;
    currentPlayerHP: number = 0;
    enemyCurrentlyFighting: number = 0;
    enemyAttack: number = 0;
    correct: string | null = ""



    @Input()
    answer = "";

    @Output() 
    playerHPEmitter = new EventEmitter<number>();
    @Output()
    EnemyEmitter = new EventEmitter<number>();
   

    
  constructor(private frontEndServ: FrontEndService, private router: Router) { 
    this.listOfQuestion = [];

    
  }

  ngOnInit(): void {
    
    this.frontEndServ.getAllQuestions().subscribe(result => 
      {
      this.listOfQuestion = result;
      this.changeQuestionsAndAnswers(0);
      this.setSessionQuestionAttack();
      this.getSessionQuestionAttack();
      this.getSessionEnemyAttack();

      
    }
    )}

  ngOnChange(): void{


  }

   
  
  

  getRandomNumber(max:number) : number {
    this.randomNumber = 1+Math.floor((Math.random() * max))
    return this.randomNumber;
};      


  changeQuestionsAndAnswers(rand:number): void{

    rand = this.getRandomNumber(79);
    this.question = this.listOfQuestion[rand].questions;
    this.answer1 = this.listOfQuestion[rand].answer1;
    this.answer2 = this.listOfQuestion[rand].answer2;
    this.answer3 = this.listOfQuestion[rand].answer3;
    this.answer4 = this.listOfQuestion[rand].answer4;
    this.correctAnswer = this.listOfQuestion[rand].correctAnswer;
    this.questionAttack = this.listOfQuestion[rand].damageValue;

    this.setSessionQuestionAttack();



    
  }

 
  setSessionQuestionAttack()
  {
    sessionStorage.setItem("questionAttack", this.questionAttack.toString() );
  }

  getSessionQuestionAttack()
  {
    // need Number() casting to convert string to number -- otherwise if set to string, no caste needed.
    this.questionAttack = Number(sessionStorage.getItem("questionAttack"));

  }

  getSessionEnemyHP(){

    this.currentEnemyHP = Number(sessionStorage.getItem("enemyHP"));

  }

  setSessionEnemyHP(){
    sessionStorage.setItem("enemyHP", this.currentEnemyHP.toString() );
  }

  getSessionPlayerHP(){

    this.currentPlayerHP = Number(sessionStorage.getItem("playerHP"));

  }

  setSessionPlayerHP(){
    sessionStorage.setItem("playerHP", this.currentPlayerHP.toString());
  }

  getSessionEnemyCurrentlyFighting(){

    this.enemyCurrentlyFighting = Number(sessionStorage.getItem("enemyCurrentlyFighting"));

  }

  setSessionEnemyCurrentlyFighting(){

    sessionStorage.setItem("enemyCurrentlyFighting", this.enemyCurrentlyFighting.toString());

  }

  getSessionEnemyAttack(){
    this.enemyAttack = Number(sessionStorage.getItem("enemyAttack"))
  }

  compareAnswers()
  {
      if(this.correctAnswer == this.answer){
     
        this.decrementEnemyHP();
        this.correct = "You got the last answer correct!";
        this.checkIfAllEnemiesDefeated();


      }
      else{
      this.decrementPlayerHP();
      this.correct = "Your last answer was incorrect.";
      this.checkPlayerHP();

      }
      this.changeQuestionsAndAnswers(0);
     


  }

  decrementEnemyHP()
  {
    this.getSessionEnemyHP();
    this.getSessionQuestionAttack();
    this.currentEnemyHP = this.currentEnemyHP - this.questionAttack;
    this.setSessionEnemyHP();
    this.EnemyEmitter.emit(this.currentEnemyHP);
  }

  decrementPlayerHP()
  {
    this.getSessionPlayerHP();
    this.getSessionEnemyAttack();
    this.currentPlayerHP = this.currentPlayerHP - this.enemyAttack;
    this.setSessionPlayerHP();
    this.playerHPEmitter.emit(this.currentPlayerHP);

  }

  checkIfAllEnemiesDefeated()
  {
    this.checkEnemyHPAndIncrementIfDefeat();
    this.getSessionEnemyCurrentlyFighting();
    if (this.enemyCurrentlyFighting >= 9) {
      // get uservictories and increment by 1
      // set uservictories to session
      this.router.navigate(["/winner"]);
      
    }
    
  }

  checkPlayerHP(){
    if (this.currentPlayerHP <= 0) {
      this.router.navigate(["/gameover"]);

    }
  }

  checkEnemyHPAndIncrementIfDefeat(){
    if (this.currentEnemyHP <= 0) {
      this.getSessionEnemyCurrentlyFighting();
      this.enemyCurrentlyFighting = this.enemyCurrentlyFighting+1;
      this.setSessionEnemyCurrentlyFighting();
      
    }
  }
}

// We will need to pull a random question with its answers and the correct  from the database - done
// we will need to assign the correct  to a local variable - done


// We will need to compare the selected question with the (correctanswer) from the database -- done
// if true, we will need to decrease enemyhp which is stored as a variable by the question value and show the user they got it correct
//        will need a check to see if enemy is defeated - mostly done

//             if enemy is defeated, increase (enemycurrentlyfighting) in the database by 1 and pull the enemy data for that new id
//                 if no new enemy is found, show winner route

// if false, we will need to decrease player hp (update database too) by enemy attack value and provide the correct  to the user
//         will need a check to see if player is defeated
// submit button will need to change to "next question" or display a next question link
// after submit button is clicked, we will need to display next question and set of answers and do this again. 
// need a boolean for a while statement (whileplaying) to loop through this while player is playing
// need a (click) for the button to do the check and display based on an if>then

// Need a (click) to move to the next question
// will need enemy data stored to local variables
// will need enemycurrentlyfighting to update when enemy is defeated