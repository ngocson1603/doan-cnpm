using Accord;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Filters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Accord.MachineLearning;
using Accord.IO;
using System.IO;
using DTO;
using BLL;
using Newtonsoft.Json;

namespace GUI.XuLy
{
    public class ID3Learn
    {
        DataSet ds_SP = new DataSet();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.QL_CUAHANGLINHKIENMAYTINH);
        BLLTuVan blltv = new BLLTuVan();
        public ID3Learn(){
            
        }
        public DataTable loadDT()
        {
            string caulenh = "select * from KetQua";

            SqlDataAdapter ds_sv = new SqlDataAdapter(caulenh, conn);
            DataTable dt = new DataTable();
            ds_sv.Fill(dt);
            return dt;
        }

        public string load(string tt1,string tt2,string tt3)
        {
            // In order to try to learn a decision tree, we will first convert this problem to a more simpler
            // representation. Since all variables are categories, it does not matter if they are represented
            // as strings, or numbers, since both are just symbols for the event they represent. Since numbers
            // are more easily representable than text string, we will convert the problem to use a discrete 
            // alphabet through the use of a Accord.Statistics.Filters.Codification codebook.</para>

            // A codebook effectively transforms any distinct possible value for a variable into an integer 
            // symbol. For example, “Sunny” could as well be represented by the integer label 0, “Overcast” 
            // by “1”, Rain by “2”, and the same goes by for the other variables. So:</para>

            // Create a new codification codebook to 
            // convert strings into integer symbols
            var codebook = new Codification(loadDT());

            // Translate our training data into integer symbols using our codebook:
            DataTable symbols = codebook.Apply(loadDT());
            List<String> a = new List<string>();

            int[][] inputs = symbols.ToArray<int>("TenTinhTrangOne", "TenTinhTrangTwo", "TenTinhTrangThree");

            int[] outputs = symbols.ToArray<int>("KetQua");

            // For this task, in which we have only categorical variables, the simplest choice 
            // to induce a decision tree is to use the ID3 algorithm by Quinlan. Let’s do it:

            // Create a teacher ID3 algorithm
            var id3learning = new ID3Learning()
            {
                // Now that we already have our learning input/ouput pairs, we should specify our
                // decision tree. We will be trying to build a tree to predict the last column, entitled
                // “PlayTennis”. For this, we will be using the “Outlook”, “Temperature”, “Humidity” and
                // “Wind” as predictors (variables which will we will use for our decision). Since those
                // are categorical, we must specify, at the moment of creation of our tree, the
                // characteristics of each of those variables. So:

                new DecisionVariable("TenTinhTrangOne",     4),
                new DecisionVariable("TenTinhTrangTwo", 4), 
                new DecisionVariable("TenTinhTrangThree",    3),

                // Note: It is also possible to create a DecisionVariable[] from a codebook:
                // DecisionVariable[] attributes = DecisionVariable.FromCodebook(codebook);
            };

            // Learn the training instances!
            DecisionTree tree = id3learning.Learn(inputs, outputs);

            // Compute the training error when predicting training instances
            double error = new ZeroOneLoss(outputs).Loss(tree.Decide(inputs));

            // The tree can now be queried for new examples through 
            // its decide method. For example, we can create a query

            int[] query = codebook.Transform(new[,]
                {
                    { "TenTinhTrangOne",     tt1 },
                    { "TenTinhTrangTwo", tt2     },
                    { "TenTinhTrangThree",   tt3    },
                });

            // And then predict the label using
            int predicted = tree.Decide(query);  // result will be 0

            // We can translate it back to strings using
            string answer = codebook.Revert("KetQua", predicted); // Answer will be: "No"
            return answer;
        }

    }
}
