﻿using System;
using System.Threading;

namespace Class_Zad_1
{
    class ThreadWorker<TResult>
    {
        Func<TResult> funk = null;
        TResult result = default;

        public ThreadWorker(Func<TResult> funk)
        {
            this.funk = funk;
        }
        public bool IsCompleted { get; private set; } = false;
        public bool IsSuccess { get; private set; } = false;
        public Exception Exception { get; private set; } = null;

        public TResult Result
        {
            get
            {
                if (Exception == null)
                {
                    if (!result.Equals(default(TResult)))
                        return result;
                    else
                    {
                        Wait();
                        return Result;
                    }
                }
                else throw Exception;
            }
        }

        public void Start()
        {
            Thread thread = new Thread(() => result = funk.Invoke());
            try
            {
                thread.Start();
                //throw new DivideByZeroException();
                IsSuccess = true;
            }
            catch (Exception e)
            {
                Exception = e;
                IsSuccess = false;
            }
            finally
            {
                IsCompleted = true;
            }

        }

        private void Wait()
        {
            Console.WriteLine("Ваш результат еще не готов, немного подождите...");
            Thread.Sleep(1000);
        }
    }
}
