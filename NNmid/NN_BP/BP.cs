using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NNmidBP.NN_BP
{
    [Serializable]
    public class BP
    {
        public bool Inputed = false;
        public const int Max_Size = 1000;
        const double upperBound = 0.9;
        const double lowerBound = 0.1;
        public double[][] weight_i_h;
        public double[][] weight_h_o;

        public int input_array_size = 5;
        public int hidden_array_size = 3;
        public int output_array_size = 3;
        public int TrainingCnt = 0;
        public double learning_rate = 0.5;
        public int number_of_input_patterns = 4;
        public int bias_array_size;
        public int y_tmp, z_tmp;
        public double max_error_tollerance = 0.1;
         
        public double[] bias;
        public double[] hidden;
        
        public double[][] input;
        public double[][] output;
        public double[][] target;

        public double[] errorsignal_output;
        public double[] errorsignal_hidden;

        public string TrainingLog;
        public BP()
        {
            const int Size     = Max_Size;
            weight_i_h         = Initailze2DArray(Size);
            weight_h_o         = Initailze2DArray(Size);
            bias               = new double[Size];
            hidden             = new double[Size];
            input              = Initailze2DArray(Size);
            output             = Initailze2DArray(Size);
            target             = Initailze2DArray(Size);
            errorsignal_output = new double[Size];
            errorsignal_hidden = new double[Size];
        }
        public double[][] Initailze2DArray(int Size)
        {
            double[][] array = new double[Size][];
            for (int i = 0; i < Size; i++)
                array[i] = new double[Size];
            return array;
        }
        public BP clone()
        {
            return XmlHelper.DeepCopy<BP>(this);
        }
        /// <summary>初始化參數(輸入大小,輸出大小,)</summary>
        public void Initialize(int in_Size,int out_Size,int hid_Size , double L_rate ,int in_patterns,double MaxErrorTor)
        {
            input_array_size         = in_Size;
            output_array_size        = out_Size;
            hidden_array_size        = hid_Size;
            learning_rate            = L_rate;
            number_of_input_patterns = in_patterns;
            max_error_tollerance     = MaxErrorTor;            
        }
        Random random = new Random();
        public double get_PosNeg10()
        {
            int signed = random.Next(0,2);
            double value=0.0;
            if (signed == 1)
                value = random.NextDouble() * 10.0 * (-1);
            else
                value = random.NextDouble() * 10.0;
            return value;
        }
        /// <summary>亂數初始化權重</summary>
        public void Rand_Init()
        {
            y_tmp = 0; z_tmp = 0;
            
            bias_array_size = hidden_array_size + output_array_size;
            bias = new double[bias_array_size];
            for (int i = 0; i < bias_array_size; i++)
                bias[i] = get_PosNeg10();

            for (int i = 0; i < input_array_size; i++)
                for (int j = 0; j < hidden_array_size; j++)
                    weight_i_h[i][j] = get_PosNeg10();

            for (int i = 0; i < hidden_array_size; i++)
                for (int j = 0; j < output_array_size; j++)
                    weight_h_o[i][j] = get_PosNeg10();
            
        }
        public bool Input_Para(RichTextBox tb_in, RichTextBox tb_target)
        {
            Inputed = false;
            string[] TestInput  = tb_in.Text.Split(new char[] { ' ', ',', '\n' });
            string[] TestOutput = tb_target.Text.Split(new char[] { ' ', ',', '\n' });
            int InCnt = 0 , OutCnt=0;
            try
            {
                for (int i = 0; i < number_of_input_patterns; i++)
                {
                    for (int j = 0; j < input_array_size; j++)
                    {
                        while (TestInput[InCnt] == "")
                            InCnt++;

                        input[i][j] =Convert.ToDouble( TestInput[InCnt]);                        
                        InCnt++;
                    }
                }
                for (int i = 0; i < number_of_input_patterns; i++)
                {
                    for (int j = 0; j < output_array_size; j++)
                    {
                        while (TestOutput[OutCnt] == "")
                            OutCnt++;

                        target[i][j] = Convert.ToDouble(TestOutput[OutCnt]);                       
                        OutCnt++;
                    }
                }              
            }
            catch { return Inputed = false; }
            return Inputed = true;
        }
        void forward_pass(int pattern)
        {
            double tmp = 0;
            // INPUT -> HIDDEN
            for (int j = 0; j < hidden_array_size; j++)
            {
                for (int i = 0; i < input_array_size; i++)
                {
                    tmp += (input[pattern][i] * weight_i_h[i][j]);
                }
                double exp = Math.Exp(-1.0 * (tmp + bias[j]));
                hidden[j] = (1.0 / (1.0 + exp));
                tmp = 0;
            }
            // HIDDEN -> OUTPUT
            for (int j = 0; j < output_array_size; j++)
            {
                for (int i = 0; i < hidden_array_size; i++)
                {
                    tmp += (hidden[i] * weight_h_o[i][j]);
                }
                double exp = Math.Exp(-1.0 * (tmp + bias[j + hidden_array_size]));
                output[pattern][j] = (1.0 / (1.0 +exp));
            }
            return;
        }
        void backward_pass(int pattern)
        {
            double tmp = 0;
            // COMPUTE ERRORSIGNAL FOR OUTPUT UNITS
            for (int i = 0; i < output_array_size; i++)
            {
                errorsignal_output[i] = (target[pattern][i] - output[pattern][i]);
            }

            // COMPUTE ERRORSIGNAL FOR HIDDEN UNITS
            for (int i = 0; i < hidden_array_size; i++)
            {
                for (int j = 0; j < output_array_size; j++)
                {
                    tmp += (errorsignal_output[j] * weight_h_o[i][j]);
                }
                errorsignal_hidden[i] = hidden[i] * (1 - hidden[i]) * tmp;
                tmp = 0.0;
            }
            // ADJUST WEIGHTS OF CONNECTIONS FROM HIDDEN TO OUTPUT UNITS
            double length = 0.0;
            for (int i = 0; i < hidden_array_size; i++)
            {
                length += hidden[i] * hidden[i];
            }
            if (length <= 0.1) length = 0.1;
            for (int i = 0; i < hidden_array_size; i++)
            {
                for (int j = 0; j < output_array_size; j++)
                {
                    weight_h_o[i][j] += (learning_rate * errorsignal_output[j] *
                    hidden[i] / length);
                }
            }
            // ADJUST BIASES OF HIDDEN UNITS
            for (int i = hidden_array_size; i < bias_array_size; i++)
            {
                bias[i] += (learning_rate * errorsignal_output[i] / length);
            }
            // ADJUST WEIGHTS OF CONNECTIONS FROM INPUT TO HIDDEN UNITS
            length = 0.0;
            for (int i = 0; i < input_array_size; i++)
            {
                length += input[pattern][i] * input[pattern][i];
            }
            if (length <= 0.1)
                length = 0.1;
            for (int i = 0; i < input_array_size; i++)
            {
                for (int j = 0; j < hidden_array_size; j++)
                {
                    weight_i_h[i][j] += (learning_rate * errorsignal_hidden[j] *
                    input[pattern][i] / length);
                }
            }
            // ADJUST BIASES FOR OUTPUT UNITS
            for (int i = 0; i < hidden_array_size; i++)
            {
                bias[i] += (learning_rate * errorsignal_hidden[i] / length);
            }
            return;
        }
        bool compare_to_target()
        {
            double tmp = 0.0, error = 0.0;
            tmp = target[y_tmp][z_tmp] - output[y_tmp][z_tmp];
            if (tmp < 0)
                error -= tmp;
            else
                error += tmp;
            if (error > max_error_tollerance)
                return false;
            error = 0.0;
            for (int y = 0; y < number_of_input_patterns; y++)
            {
                for (int z = 0; z < output_array_size; z++)
                {
                    tmp = target[y][z] - output[y][z];
                    if (tmp < 0)
                        error -= tmp;
                    else
                        error += tmp;
                    if (error > max_error_tollerance)
                    {
                        y_tmp = y;
                        z_tmp = z;
                        return false;
                    }
                    error = 0.0;
                }
            }
            return true;
        }
        
        public string leran10000(Label lab)
        {
            
            string str = "";
            //學習次數
            for (int i = 1; i <= 10000; i++)
            {
                str += String.Format("\nstart learning round {0}:\n ", i);
                if (learn())
                {
                    TrainingCnt = i;
                    str += ("\n\n FINISH LEARNING!! \n");                    
                    break;
                }
                else
                {
                    str += LinkStrList(test());
                }

                lab.Parent.Invoke((MethodInvoker)delegate
                {
                    lab.Text = i.ToString();
                });    
            }
            return TrainingLog = str;
        }
        public string LinkStrList(List<string> strList)
        {
            string str_out="";
            int cnt =1;
            foreach(string str in strList)
            {
                str_out+= String.Format("\nOutput pattern {0}:\n",cnt++);
                str_out+= str;
            }
            return str_out;
        }
        public bool learn()
        {
            for (int i = 0; i < number_of_input_patterns; i++)
            {
                forward_pass(i);
                backward_pass(i);
            }
            if (compare_to_target()) //learning successful;            
                return true;

            return false;//learning not successful yet
        }
        public List<string> test()
        {
            List<string> list_str = new List<string>();
            for (int i = 0; i < number_of_input_patterns; i++)
            {
                forward_pass(i);
                list_str.Add(output_to_screen(i));
            }
            return list_str;
        }
        public string test_2(TextBox Input)
        {
            string[] TestInput = Input.Text.Split(new char[] { ' ', ',', '\n' });
            int InCnt = 0;
            try
            {
                //給予指定的input
                for (int j = 0; j < input_array_size; j++)
                {
                    while (TestInput[InCnt] == "")
                        InCnt++;

                    input[0][j] = Convert.ToDouble(TestInput[InCnt]);
                    InCnt++;
                }
                forward_pass(0);
                return output_to_screen(0);
            }
            catch
            {
                return "";
            }
        }

        public string output_to_screen(int pattern)
        {
            string str_ouput = "";
            int x;
            
            for (x = 0; x < output_array_size; x++)
            {
                str_ouput += String.Format("\n{0}: {1:F5}    binary: ", (x + 1), output[pattern][x]);

                if (output[pattern][x] >= upperBound)
                    str_ouput += "1";
                else if (output[pattern][x] <= lowerBound)
                    str_ouput += "0";
                else
                    str_ouput += "X";
            }
            str_ouput += "\n";
            return str_ouput;
        }
    }
}
