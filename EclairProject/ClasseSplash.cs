using System;

namespace EclairProject
{
    public class ClasseSplash
    {
        public event EventHandler<HardWorkerEventArgs> ProgressChanged;

        public event EventHandler HardWorkDone;

        public void DoHardWork()
        {
            for (int i = 1; i <= 300; i++)
            {
                for (int j = i; j <= 460000; j++)
                {
                    Math.Pow(i, j);
                }
                this.OnProgressChanged(i);
            }
            this.OnHardWorkDone();
        }

        private void OnProgressChanged(int progress)
        {
            var handler = this.ProgressChanged;
            if (handler != null)
            {
                handler(this, new HardWorkerEventArgs(progress));
            }
        }

        private void OnHardWorkDone()
        {
            var handler = this.HardWorkDone;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
    }

    public class HardWorkerEventArgs : EventArgs
    {
        public HardWorkerEventArgs(int progress)
        {
            this.Progress = progress;
        }

        public int Progress
        {
            get;
            private set;
        }
    }
}