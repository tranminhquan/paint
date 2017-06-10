using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.IO;
using System.Windows.Forms;

namespace Paint
{
    public class SpeechRecognition
    {
        private SpeechRecognitionEngine recognizer;
        private Grammar grammar;
        private string resultText;
        private float confidence;
        public delegate void SEND(string s);
        public SEND _sender;

        public string ResultText { get; set; }
        public float Confindence { get; set; }
        public SpeechRecognition()
        {
            //Add grammar
            string[] dataGram = new string[] { "one", "two", "three", "four" };  // File.ReadAllLines(@"E:\Courses\4th - Semester\Truc quan\Projects\DataGrammar\Grammar.txt");
            Choices basic = new Choices();
            foreach(string i in dataGram)
            {
                basic.Add(i);
            }
            GrammarBuilder builder = this.CreateStructure(basic);
            grammar = new Grammar(builder);

            //Init recognizer
            recognizer = new SpeechRecognitionEngine();
            recognizer.SetInputToDefaultAudioDevice();       
            if (grammar != null)
            {
                recognizer.LoadGrammar(grammar);
                recognizer.SpeechRecognized += Recognizer_SpeechRecognized; // Recoginized success
                //recognizer.SpeechDetected += Recognizer_SpeechDetected; //  Not sure
                //recognizer.SpeechRecognitionRejected += Recognizer_SpeechRecognitionRejected;  //Failed
               // recognizer.SpeechHypothesized += Recognizer_SpeechHypothesized;

                //Set confidence
                confidence = 0.5f;
            }
        }

        //private void Recognizer_SpeechHypothesized(object sender, SpeechHypothesizedEventArgs e)
        //{
                  
        //}

        //private void Recognizer_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        //{
            
        //}

        //private void Recognizer_SpeechDetected(object sender, SpeechDetectedEventArgs e)
        //{
            
        //}

        public void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence >= confidence)
            {
                resultText = e.Result.Text;
                _sender(resultText);
            }       
        }

        public void Start()
        {
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
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
