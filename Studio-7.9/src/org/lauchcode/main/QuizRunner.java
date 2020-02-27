package org.lauchcode.main;

import java.util.ArrayList;
import java.util.Arrays;

import org.lauchcode.main.quiz.Quiz;
import org.lauchcode.main.quiz.question.Checkbox;
import org.lauchcode.main.quiz.question.MultipleChoice;
import org.lauchcode.main.quiz.question.TrueFalse;

public class QuizRunner {
	public static void main(String[] args) {
		Quiz myQuiz = new Quiz(new ArrayList<>());
		ArrayList<String> possAns1 = new ArrayList<>(Arrays.asList("Garfield", "Salem", "Cheshire", "Tom"));
		ArrayList<Integer> correctAns1 = new ArrayList<>(Arrays.asList(2, 3));
		Checkbox newQuestion1 = new Checkbox(2, "Who is the best cat in the world?", possAns1, correctAns1);
		myQuiz.addQuestion(newQuestion1);
		ArrayList<String> possAns2 = new ArrayList<>(Arrays.asList("Doc", "Tillie", "Gizmo", "Benji", "Nala"));
		MultipleChoice newQuestion2 = new MultipleChoice(1, "Who won the Halloween Costume Contest?", 3, possAns2);
		myQuiz.addQuestion(newQuestion2);
		TrueFalse newQuestion3 = new TrueFalse(1, "Are all dogs the best?", true);
		myQuiz.addQuestion(newQuestion3);

		myQuiz.runQuiz();

		myQuiz.gradeQuiz();
	}

}
