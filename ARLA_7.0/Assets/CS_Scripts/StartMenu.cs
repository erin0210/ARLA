using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

	public void GotoMainScene()
	{
		SceneManager.LoadScene ("StartMenu");
	}

	public void GotoMainTeacherScene()
	{
		SceneManager.LoadScene ("StartMenuTeacher");
	}

	public void GotoDictionaryScene()
    {
        SceneManager.LoadScene("dictionary");
    }

    public void GotoCertificateScene()
    {
        SceneManager.LoadScene("certificate");
    }

    public void GotoHelpScene()
	{
		SceneManager.LoadScene ("HelpMenu");
	}

	public void GotoLoginScene()
	{
		SceneManager.LoadScene ("login");
	}

	public void GotoARGuideScene()
	{
		SceneManager.LoadScene ("ARGuide");
	}

	public void GotoQuizGuideScene()
	{
		SceneManager.LoadScene ("QuizGuide");
	}

	public void GotoEvaluationGuideScene()
	{
		SceneManager.LoadScene ("EvaluationGuide");
	}

	public void GotoLoginHintScene()
	{
		SceneManager.LoadScene ("loginHint");
	}

	public void GotoChpOverviewScene()
	{
		SceneManager.LoadScene ("ChpOverview");
	}

	public void GotoChp10()
	{
		SceneManager.LoadScene ("Chp10");
	}

	public void GotoChp11()
	{
		SceneManager.LoadScene ("Chp11");
	}

	public void GotoChp12()
	{
		SceneManager.LoadScene ("Chp12");
	}

	public void GotoQuizScene()
	{
		SceneManager.LoadScene ("MCQ");
	}

    public void GotoQuizDoneScene()
    {
        SceneManager.LoadScene("MCQdone");
    }

    public void GotoFeedbackOverview()
	{
		SceneManager.LoadScene ("FeedbackChpOverview");
	}

    public void GotoFeedback()
    {
        SceneManager.LoadScene("Feedback");
    }

	public void GotoFeedbackSubmit()
	{
		SceneManager.LoadScene("FeedbackSubmit");
	}

    public void GotoCharacter()
    {
        SceneManager.LoadScene("CharacterModuleTarget");
    }

    public void GotoCharacter2()
    {
        SceneManager.LoadScene("CharacterModuleTarget2");
    }

    public void GotoCharacter3()
    {
        SceneManager.LoadScene("CharacterModuleTarget3");
    }

    public void GotoCharacter4()
    {
        SceneManager.LoadScene("EndCharacterModule");
    }


    public void GotoSubmittedScene()
	{
		SceneManager.LoadScene ("Submitted");
	}

	public void GotoSubmittedTeacherScene()
	{
		SceneManager.LoadScene ("FeedbackChpOverview_Teacher");
	}

	public void GotoBook()
	{
		SceneManager.LoadScene ("book");
	}
}
