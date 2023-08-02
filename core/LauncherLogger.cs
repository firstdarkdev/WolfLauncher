using System;
using System.Collections.Concurrent;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WolfLauncher.model;

/**
 * Author: HypherionSA
 * Log Window controller for the Launcher
 **/
namespace WolfLauncher.core
{
    public class LauncherLogger
    {
        // Static instance accessible anywhere
        public static readonly LauncherLogger INSTANCE = new LauncherLogger();

        // Running Instance Log Directory and File
        private readonly DirectoryInfo logDir = new DirectoryInfo("launcherdata/logs");
        private readonly FileInfo logFile = new FileInfo("launcherdata/logs/running.log");

        // Log Queue, waiting to be written to log and log window
        private ConcurrentQueue<string> logQueue = new ConcurrentQueue<string>();
        // Timer to control logging, so it doesn't spam
        private Timer tmr;

        // Variables for the active Console window if any
        public RichTextBox logWindow { get; set; }
        public Instance loggingInstance { get; set; }
        public bool canUpdateLog { get; set; }

        // Should not be created elsewhere
        private LauncherLogger()
        {
            // Create log directory if it doesn't exist
            if (!logDir.Exists)
                logDir.Create();

            // Setup the log timer
            tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Enabled = false;
            tmr.Tick += Tmr_Elapsed;
        }

        /**
         * Check if any pending log entries are present, and process them
         **/
        private void Tmr_Elapsed(object sender, EventArgs e)
        {
            // Log is empty, so we don't continue
            if (logQueue.Count == 0)
                return;

            // Dump the queue into a string
            var sb = new StringBuilder();
            while (logQueue.TryDequeue(out string msg))
            {
                sb.AppendLine(msg);
            }

            // Write to log file for persistance
            File.AppendAllText(logFile.FullName, sb.ToString());

            // Console window is open, so we update the log window
            if (logWindow != null && !logWindow.IsDisposed && canUpdateLog)
                logWindow.AppendText(sb.ToString());
        }

        /**
         * Called when an instance is started, to start the logging process
         **/
        public void startLogging(Instance ins)
        {
            // Disable timer and remove previous log if it exists
            tmr.Enabled = false;
            if (logFile.Exists)
                logFile.Delete();

            // Clear the queue and enable the timer
            logQueue = new ConcurrentQueue<string>();
            tmr.Enabled = true;

            loggingInstance = ins;
        }

        /**
         * Add an entry to the log
         **/
        public void addLog(string log)
        {
            // Check if string is empty and ignore if it is
            if (string.IsNullOrEmpty(log))
                return;

            // Add to log queue
            logQueue.Enqueue(log);
        }

        /**
         * Clear the current log and log file
         **/
        public void clearLog()
        {
            // Disable timer and delete log file
            tmr.Enabled = false;
            if (logFile.Exists)
                logFile.Delete();

            // Clear queue and re-enable timer
            logQueue = new ConcurrentQueue<string>();
            tmr.Enabled = true;
        }

        /**
         * Load persisted log from disk to be used in log window
         **/
        public void loadLog(Instance ins = null)
        {
            // Instance Console window is closed, so we ignore
            if (logWindow == null || logWindow.IsDisposed)
                return;

            // Check if the console window matches the running instance
            if (loggingInstance != null && ins != null && ins == loggingInstance)
            {
                // Clear old log from window if any
                logWindow.Clear();

                // Check if persisted log exists
                if (!logFile.Exists)
                    return;

                // Load log from file into window
                string log = File.ReadAllText(logFile.FullName, Encoding.UTF8);
                logWindow.Text = log;
            }
        }
    }
}
