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
    answer1:string = "loading";
    answer2:string = "loading.";
    answer3:string = "loading..";
    answer4:string = "loading...";
    correctAnswer:string = "Correct Answer ";
    questionAttack:number = 0;
    listOfQuestion:Question[];
    randomNumber:number = 0;
    currentEnemyHP: number = 0;
    currentPlayerHP: number = 0;
    enemyCurrentlyFighting: number = 0;
    enemyAttack: number = 0;
    correct: string | null = ""
    userVictories:number = 0;
    hidden = ""


    @Input()
    answer = this.hidden;

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

    this.currentEnemyHP = Number(sessionStorage.getItem("enemyHealth"));

  }

  setSessionEnemyHP(){
    sessionStorage.setItem("enemyHealth", this.currentEnemyHP.toString() );
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

  getSessionUserVictories(){
    this.userVictories = Number(sessionStorage.getItem("userVictories"));
  }

  setSessionUserVictories(){
    sessionStorage.setItem("userVictories" , this.userVictories.toString());
  }

  compareAnswers()
  {
    
      if(this.correctAnswer == this.answer){
     
        this.decrementEnemyHP();
        this.correct = "You got the last answer correct!";
        this.checkIfAllEnemiesDefeated();
        this.changeQuestionsAndAnswers(0);
        this.answer = this.hidden;


      }
      
      else if (this.answer == this.hidden){
        this.correct = "Please select an answer!"
      }

      else{
        this.decrementPlayerHP();
        this.correct = "Your last answer was incorrect.";
        this.checkPlayerHP();
        this.changeQuestionsAndAnswers(0);
        this.answer = this.hidden;
  
        }
     
     


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
      this.getSessionUserVictories();
      this.userVictories += 1;
      this.setSessionUserVictories();
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

  saveAndLogout(){
    this.router.navigate(["/logout"])
  }
}
