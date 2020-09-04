package org.lauchcode.main.quiz;

import java.util.ArrayList;

import org.lauchcode.main.quiz.question.Question;

public class Quiz {
	private ArrayList<Question> questions;
	private int score;
	private int total;

	public Quiz(ArrayList<Question> questions) {
		this.questions = questions;
		this.score = 0;
		this.total = 0;
		for (int i = 0; i < questions.size(); i++) {
			this.total = this.total + questions.get(i).getPointValue();
		}
	}

	public void addQuestion(Question newQuestion) {
		this.questions.add(newQuestion);
		this.total = this.total + newQuestion.getPointValue();
	}

	public void runQuiz() {
		for (int i = 0; i < questions.size(); i++) {
			questions.get(i).displayQuestion();
			questions.get(i).displayAnswers();
			int pts = questions.get(i).getAnswers();
			updateScore(pts);
		}
	}

	public void updateScore(int x) {
		this.score = this.score + x;
	}

	public void gradeQuiz() {
		System.out.println("You finished the quiz! Your score is: " + score + "/" + total);
	}

}
