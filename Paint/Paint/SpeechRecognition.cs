using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.IO;
using System.Speech.Synthesis;

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

        //speaker
        private SpeechSynthesizer speaker;

        public string ResultText
        {
            get { return resultText; }
            set { resultText = value;}
        }
        public float Confindence
        {
            get { return confidence; }
            set { confidence = value; }
        }
        public SpeechRecognition()
        {
            #region Set for speech reconition
            //Add grammar
            string[] dataGram =  File.ReadAllLines(@".\Grammar.txt");
            Choices basic = new Choices();
            foreach(string i in dataGram)
            {
                if (i=="size")
                {
                    for (int index=1;index<=10;index++)
                    {
                        string temp = i + " " + index.ToString();
                        basic.Add(temp);
                    }
                }              
                else
                {
                    basic.Add(i);
                }
                
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
                recognizer.SpeechRecognitionRejected += Recognizer_SpeechRecognitionRejected;  //Failed
               // recognizer.SpeechHypothesized += Recognizer_SpeechHypothesized;

                //Set confidence
                confidence = 0.5f;
            }
            #endregion

            #region Set for speaker
            //Init speaker
            speaker = new SpeechSynthesizer();
            speaker.SetOutputToDefaultAudioDevice();
            speaker.SelectVoiceByHints(VoiceGender.Female);
            speaker.Volume = 100;
            speaker.Rate = 2;
            #endregion
        }

        //private void Recognizer_SpeechHypothesized(object sender, SpeechHypothesizedEventArgs e)
        //{

        //}

        private void Recognizer_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            speaker.Speak("Can't detect");               
        }

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
            speaker.Speak("Hello! How can I help you?");       
        }

        public void Stop()
        {
            speaker.Speak("Speech Recognition will turn off now! Goodbye!");
            recognizer.RecognizeAsyncStop();
            
        }

        public GrammarBuilder CreateStructure(params Choices[] elements)    //Create new structure
        {
            GrammarBuilder builder = new GrammarBuilder();
            foreach(Choices i in elements)
            {
                builder.Append(i);
            }
            return builder;
        }

        
    }
}
