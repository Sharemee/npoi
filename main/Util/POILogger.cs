using System;
using System.Text;
using System.Collections;
using System.Globalization;

namespace NPOI.Util
{
    public abstract class POILogger
    {
        public const int DEBUG = 1;
        public const int INFO = 3;
        public const int WARN = 5;
        public const int ERROR = 7;
        public const int FATAL = 9;

        /// <summary>
        /// package scope so it cannot be instantiated outside of the util package.
        /// You need a POILogger? Go to the POILogFactory for one
        /// </summary>
        public POILogger() { }

        abstract public void Initialize(String cat);

        /**
         * Log a message
         *
         * @param level One of DEBUG, INFO, WARN, ERROR, FATAL
         * @param obj1 The object to Log.  This is converted to a string.
         */
        abstract public void Log(int level, Object obj1);

        /**
         * Log a message
         *
         * @param level One of DEBUG, INFO, WARN, ERROR, FATAL
         * @param obj1 The object to Log.  This is converted to a string.
         * @param exception An exception to be Logged
         */
        abstract public void Log(int level, Object obj1, Exception exception);

        /// <summary>
        /// Check if a Logger is enabled to Log at the specified level
        /// </summary>
        /// <param name="level">level One of DEBUG, INFO, WARN, ERROR, FATAL</param>
        /// <returns></returns>
        abstract public bool Check(int level);

        /// <summary>
        /// Log a message. Lazily appends Object parameters together.
        /// </summary>
        /// <param name="level">level One of DEBUG, INFO, WARN, ERROR, FATAL</param>
        /// <param name="obj1">first object to place in the message</param>
        /// <param name="obj2">second object to place in the message</param>
        public virtual void Log(int level, Object obj1, Object obj2)
        {
            if (Check(level))
            {
                Log(level, new StringBuilder(32).Append(obj1).Append(obj2));
            }
        }

        public virtual void Log(int level, Object obj1, Object obj2, Object obj3)
        {
            if (Check(level))
            {
                Log(level, new StringBuilder(48).Append(obj1).Append(obj2).Append(obj3));
            }
        }

        public virtual void Log(int level, Object obj1, Object obj2, Object obj3, Object obj4)
        {
            if (Check(level))
            {
                Log(level, new StringBuilder(64).Append(obj1).Append(obj2).Append(obj3).Append(obj4));
            }
        }

        public virtual void Log(int level, Object obj1, Object obj2, Object obj3, Object obj4, Object obj5)
        {
            if (Check(level))
            {
                Log(level, new StringBuilder(80).Append(obj1).Append(obj2).Append(obj3).Append(obj4).Append(obj5));
            }
        }

        public virtual void Log(int level, Object obj1, Object obj2, Object obj3, Object obj4, Object obj5, Object obj6)
        {
            if (Check(level))
            {
                Log(level, new StringBuilder(96).Append(obj1).Append(obj2).Append(obj3).Append(obj4).Append(obj5).Append(obj6));
            }
        }

        public virtual void Log(int level, Object obj1, Object obj2, Object obj3, Object obj4, Object obj5, Object obj6, Object obj7)
        {
            if (Check(level))
            {
                Log(level, new StringBuilder(112).Append(obj1).Append(obj2).Append(obj3).Append(obj4).Append(obj5).Append(obj6).Append(obj7));
            }
        }

        public virtual void Log(int level, Object obj1, Object obj2, Object obj3, Object obj4, Object obj5, Object obj6, Object obj7, Object obj8)
        {
            if (Check(level))
            {
                Log(level, new StringBuilder(128).Append(obj1).Append(obj2).Append(obj3).Append(obj4).Append(obj5).Append(obj6).Append(obj7).Append(obj8));
            }
        }

        /// <summary>
        /// Log an exception, without a message
        /// </summary>
        /// <param name="level">level One of DEBUG, INFO, WARN, ERROR, FATAL</param>
        /// <param name="exception">exception An exception to be Logged</param>
        public virtual void Log(int level, Exception exception)
        {
            Log(level, null, exception);
        }

        public virtual void Log(int level, Object obj1, Object obj2, Exception exception)
        {
            if (Check(level))
            {
                Log(level, new StringBuilder(32).Append(obj1).Append(obj2), exception);
            }
        }

        public virtual void Log(int level, Object obj1, Object obj2, Object obj3, Exception exception)
        {
            if (Check(level))
            {
                Log(level, new StringBuilder(48).Append(obj1).Append(obj2).Append(obj3), exception);
            }
        }

        public virtual void Log(int level, Object obj1, Object obj2, Object obj3, Object obj4, Exception exception)
        {
            if (Check(level))
            {
                Log(level, new StringBuilder(64).Append(obj1).Append(obj2).Append(obj3).Append(obj4), exception);
            }
        }

        public virtual void Log(int level, Object obj1, Object obj2, Object obj3, Object obj4, Object obj5, Exception exception)
        {
            if (Check(level))
            {
                Log(level, new StringBuilder(80).Append(obj1).Append(obj2).Append(obj3).Append(obj4).Append(obj5), exception);
            }
        }

        public virtual void Log(int level, Object obj1, Object obj2, Object obj3, Object obj4, Object obj5, Object obj6, Exception exception)
        {
            if (Check(level))
            {
                Log(level, new StringBuilder(96).Append(obj1).Append(obj2).Append(obj3).Append(obj4).Append(obj5).Append(obj6), exception);
            }
        }

        public virtual void Log(int level, Object obj1, Object obj2, Object obj3, Object obj4, Object obj5, Object obj6, Object obj7, Exception exception)
        {
            if (Check(level))
            {
                Log(level, new StringBuilder(112).Append(obj1).Append(obj2).Append(obj3).Append(obj4).Append(obj5).Append(obj6).Append(obj7), exception);
            }
        }

        public virtual void Log(int level, Object obj1, Object obj2, Object obj3, Object obj4, Object obj5, Object obj6, Object obj7, Object obj8, Exception exception)
        {
            if (Check(level))
            {
                Log(level, new StringBuilder(128).Append(obj1).Append(obj2).Append(obj3).Append(obj4).Append(obj5).Append(obj6).Append(obj7).Append(obj8), exception);
            }
        }
    }
}
