using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.IO;

namespace Paint
{
    public class SpeechRecognition
    {
        private SpeechRecognitionEngine recognizer;
        private Grammar grammar;
        private string resultText;
        private float confidence;

        public string ResultText { get; set; }
        public float Confindence { get; set; }
        public SpeechRecognition()
        {
            //Init recognizer
            recognizer = new SpeechRecognitionEngine();
            recognizer.SetInputToDefaultAudioDevice();       
            if (grammar != null)
            {
                recognizer.LoadGrammar(grammar);
                recognizer.SpeechRecognized += Recognizer_SpeechRecognized; // Recoginized success
                recognizer.SpeechDetected += Recognizer_SpeechDetected; //  Not sure
                recognizer.SpeechRecognitionRejected += Recognizer_SpeechRecognitionRejected;  //Failed
                recognizer.SpeechHypothesized += Recognizer_SpeechHypothesized;

                //Set confidence
                confidence = 0.5f;
            }
        }

        private void Recognizer_SpeechHypothesized(object sender, SpeechHypothesizedEventArgs e)
        {
            throw new NotImplementedException();      
        }

        private void Recognizer_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            throw new NotImplementedException();   
        }

        private void Recognizer_SpeechDetected(object sender, SpeechDetectedEventArgs e)
        {
            throw new NotImplementedException();   
        }

        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence >= confidence)
            {
                resultText = e.Result.Text;
            }       
        }

        public void Start()
        {
            while (true)
            {
                recognizer.Recognize();
            } 
        }

        public void Stop()
        {
            recognizer.RecognizeAsyncStop();
        }

        public GrammarBuilder CreateStructure(params Choices[] elements)    //Create new structure
        {
            GrammarBuilder buider = new GrammarBuilder();
            foreach(Choices i in elements)
            {
                buider.Append(i);
            }
            return buider;
        }

        
    }
}
