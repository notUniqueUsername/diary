using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace DiaryAppLibs
{
    /// <summary>
    /// Класс для воспроизведения звука средствами библиотеки NAduio
    /// </summary>
    public class DiarySoundPlayer
    {
        private WaveOutEvent _outputDevice;
        private AudioFileReader _audioFile;
        private string _pathToAudio;
        private WaveOut waveOut;
        public DiarySoundPlayer(string pathToAudio)
        {
            _outputDevice = new WaveOutEvent();
            _pathToAudio = pathToAudio;
            
        }
        public void Play()
        {
            _audioFile = new AudioFileReader(_pathToAudio);
            _outputDevice.Init(_audioFile);
            _outputDevice.Play();
        }
        public void Stop()
        {
            if (!(waveOut == null))
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }

        }
        public void Ring()
        {
            if (waveOut == null)
            {
                AudioFileReader reader = new AudioFileReader(_pathToAudio);
                LoopAudio loop = new LoopAudio(reader);
                waveOut = new WaveOut();
                waveOut.Init(loop);
                waveOut.Play();
            }
        }
    }
}
