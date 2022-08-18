using System;
using System.Collections.Generic;

namespace MVC
{
    public class BeatModel : IBeatModel
    {
        private readonly List<IBeatObserver> _beatObservers = new List<IBeatObserver>();
        private readonly List<IBPMObserver> _bpmObservers = new List<IBPMObserver>();
        private int _bpm = 120;
        private bool _stop = false;
        //private Clip _clip;

        public void Initialize()
        {
            try
            {
                // Not sure how C# handle audio
                var filePath = @"c:\temp\clap.wav";
                //var resource = File.Open(filePath, FileMode.Open);
                //var clip = (Clip)AudioSystem.GetLine(new Line.Info(clip.class));
                //clip.Open(AudioSystem.GetAudioInputStream(filePath));

            } catch (Exception e)
            {
            }
        }

        public void On()
        {
            _bpm = 90;
            NotifyBPMObservers();
            _stop = false;
        }

        public void Off()
        {
            StopBeat();
            _stop = true;
        }

        public void Run()
        {
            while (!_stop)
            {
                PlayBeat();
                NotifyBeatObservers();
                try
                {
                } catch (Exception e)
                {
                }
            }
        }

        public void SetBPM(int bpm)
        {
            _bpm = bpm;
            // Notify all observers right away
            NotifyBPMObservers();
        }

        private void NotifyBeatObservers()
        {
            _beatObservers.ForEach(ob => ob.UpdateBeat());
        }

        private void NotifyBPMObservers()
        {
            _bpmObservers.ForEach(ob => ob.UpdateBPM());
        }

        private void PlayBeat()
        {
            //_clip.SetFramePosition(0);
            //_clip.Start();
        }

        private void StopBeat()
        {
            //_clip.SetFramePosition(0);
            //_clip.Stop();
        }

        public int GetBPM()
        {
            return _bpm;
        }

        public void RegisterObserver(IBeatObserver beatObserver)
        {
            _beatObservers.Add(beatObserver);
        }

        public void RemoveObserver(IBeatObserver beatObserver)
        {
            var idx = _beatObservers.IndexOf(beatObserver);
            if (idx >= 0) _beatObservers.RemoveAt(idx);
        }

        public void RegisterObserver(IBPMObserver BPMObserver)
        {
            _bpmObservers.Add(BPMObserver);
        }

        public void RemoveObserver(IBPMObserver BPMObserver)
        {
            var idx = _bpmObservers.IndexOf(BPMObserver);
            if (idx >= 0) _bpmObservers.RemoveAt(idx);
        }
    }
}
