using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Speech.Tts;
using Android.Views;
using Android.Widget;
using Demo5.Droid.Services;
using Demo5.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeechImplementation))]
namespace Demo5.Droid.Services
    {
        public class TextToSpeechImplementation : Java.Lang.Object, ITextToSpeech, TextToSpeech.IOnInitListener
        {
            TextToSpeech speaker;
            string toSpeak;

            public void Speak(string text)
            {
                toSpeak = text;
                if (speaker == null)
                {
                    speaker = new TextToSpeech(Forms.Context as Activity, this);
                }
                else
                {
                    speaker.Speak(toSpeak, QueueMode.Flush, null, null);
                }
            }

            public void OnInit(OperationResult status)
            {
                if (status.Equals(OperationResult.Success))
                {
                    speaker.Speak(toSpeak, QueueMode.Flush, null, null);
                }
            }
        }
    }
