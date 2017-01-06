using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.Serialization.Formatters.Binary;

namespace NNmidBP.NN_BP
{
    public class BP_FileHandler
    {
        BP bp;
        public BP_FileHandler(ref BP bp)
        {
            this.bp = bp;
        }
        public void SaveTo(string FilePath)
        {
            XmlHelper.SerializeObject(FilePath, bp);
        }
        public BP Load_From(string FilePath)
        {
            try
            {
                return XmlHelper.DeserializeObject<BP>(FilePath);
            }
            catch
            {
                return null;
            }
            
        }
        public void SaveBy_OpenFIleDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.AddExtension = true;
            openFileDialog.DefaultExt = "bp";
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.CheckFileExists = false;
            openFileDialog.CheckPathExists = false;

            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                SaveTo(file);
            }
        }
        public BP LoadBy_OpenFIleDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                return bp = Load_From(file);
            }
            return null;
        }
    }
    public static class XmlHelper
    {
        /// <summary>
        /// Serialize object in XML format inside a file.
        /// </summary>
        /// <param name="filename">The file that serialize object will be saved.</param>
        /// <param name="objectToSerialize">The object to serialize.</param>
        public static void SerializeObject(string filename, object objectToSerialize)
        {
            try// Open for read only.
            {
                using (Stream stream = File.Open(filename, FileMode.Create, FileAccess.ReadWrite))
                {
                    XmlSerializer xs = new XmlSerializer(objectToSerialize.GetType());
                    XmlTextWriter xmlTextWriter = new XmlTextWriter(stream, Encoding.UTF8);

                    xs.Serialize(xmlTextWriter, objectToSerialize);
                    stream.Close();
                }
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// Deserializes Object from a file.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename">The file with the serialize object.</param>        
        public static T DeserializeObject<T>(string filename)
        {
            T objectToSerialize;
            try// Open for read only.
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));

                using (Stream stream = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    objectToSerialize = (T)xs.Deserialize(stream);
                    stream.Close();
                }
            }
            catch (Exception)
            {
                return default(T);
            }
            return objectToSerialize;
        }
        /// <summary>
        ///  Serialize a Array by BinaryFormatter
        /// </summary>
        /// <param name="FILE_PATH">Path for saving file</param>
        /// <param name="vars">Objects to be serialized</param>
        public static void BinarySerializeArray(string FILE_PATH, object[] vars)
        {
            using (FileStream fs = new FileStream(FILE_PATH, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                foreach (var v in vars)
                    bf.Serialize(fs, v);
                fs.Close();
            }
        }

        public static object[] BinaryDeserializeArray(string FILE_PATH, int count)
        {
            object[] RetObj = new object[count];
            if (!File.Exists(FILE_PATH))
                return null;
            using (FileStream fs = new FileStream(FILE_PATH, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                for (int i = 0; i != count; ++i)
                {
                    try
                    {
                        RetObj[i] = null;
                        RetObj[i] = bf.Deserialize(fs);
                    }
                    catch (Exception)
                    {
                        //MessageBox.Show(e.ToString());
                        return null;
                    }
                }
                fs.Close();
            }

            return RetObj;
        }
        /// <summary>
        ///  將任何物件轉為ByteArray
        /// </summary>
        /// <param name="source">要轉換的物件 註:必需註記可Serialize</param>        
        public static byte[] ObjectToByteArray(object source)
        {
            if (source == null)
                return null;
            if (source.GetType() == typeof(Bitmap))
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Bitmap bmp = (Bitmap)source;
                        bmp.Save(ms, ImageFormat.Png);
                        return ms.ToArray();
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }
            var formatter = new BinaryFormatter();
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, source);
                return stream.ToArray();
            }
        }
        /// <summary>
        /// 將可轉換為Bitmap的byte陣列轉換成bitmap
        /// </summary>
        /// <param name="bytes">要轉換的Byte陣列</param>        
        public static Bitmap ToBitmap(byte[] bytes)
        {
            if (bytes == null)
                return null;
            else
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        Bitmap bmp = new Bitmap(ms);
                        bmp = bmp.Clone(new Rectangle(0, 0, bmp.Width, bmp.Height), PixelFormat.Format24bppRgb);
                        return bmp;
                    }
                }
                catch (Exception)
                { return null; }
            }

        }
        public static T DeepCopy<T>(T other)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ms, other);
                ms.Position = 0;
                return (T)formatter.Deserialize(ms);
            }
        }
    }
}
