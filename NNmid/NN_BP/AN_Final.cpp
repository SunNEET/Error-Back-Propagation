#include <cstdio>
#include <string>
#include <cstdlib>
#include <cmath>
#include <ctime>
#include <vector>
#include <iostream>
using namespace std;
#define ub 0.9
#define lb 0.1
double weight_i_h[100][100];
double weight_h_o[100][100];

int input_array_size;
int hidden_array_size;
int output_array_size;
double learning_rate;
int number_of_input_patterns;
int bias_array_size;
int y_tmp,z_tmp;
double max_error_tollerance;
double bias[100];
double input[100][100];
double hidden[100];
double output[100][100];
double target[100][100];
double errorsignal_output[100];
double errorsignal_hidden[100];

void init()
{
	
	srand(time(NULL));
	y_tmp = 0;	z_tmp = 0; max_error_tollerance = 0.1;
	cin >> input_array_size;
	cin >> hidden_array_size;
	cin >> output_array_size;
	cin >> learning_rate;
	cin >> number_of_input_patterns;
	bias_array_size = hidden_array_size + output_array_size;
	double tmp;
	for(int i=0;i<bias_array_size;i++){
		// cin >> tmp;
		// bias[i] = tmp;
		int rnd = rand()%10000;
		int sign = pow(-1,rand()%2+1);
		bias[i] = sign*1.0*rnd/1000;
	}
	for(int i=0;i<input_array_size;i++){
		for(int j=0;j<hidden_array_size;j++){
			// cin >> tmp;
			// weight_i_h[i][j] = tmp;
			int rnd = rand()%10000;
			int sign = pow(-1,rand()%2+1);
			weight_i_h[i][j] = sign*1.0*rnd/1000;
			
		}
	}
	for(int i=0;i<hidden_array_size;i++){
		for(int j=0;j<output_array_size;j++){
			// cin >> tmp;
			// weight_h_o[i][j] = tmp ;
			int rnd = rand()%10000;
			int sign = pow(-1,rand()%2+1);
			weight_h_o[i][j] = sign*1.0*rnd/1000;
		}
	}
	for(int i=0;i<number_of_input_patterns;i++){
		for(int j=0;j<input_array_size;j++){
			cin >> tmp;
			input[i][j] = tmp;
		}
	}
	for(int i=0;i<number_of_input_patterns;i++){
		for(int j=0;j<output_array_size;j++){
			cin >> tmp;
			target[i][j] = tmp;
		}
	}
}
void forward_pass(int pattern)
{
	double tmp = 0;
	// INPUT -> HIDDEN
	for(int j=0;j<hidden_array_size;j++){
		for(int i=0;i<input_array_size;i++){
			tmp += (input[pattern][i] * weight_i_h[i][j]);
		}
		hidden[j] = (1.0 / (1.0 + exp(-1.0*(tmp + bias[j]))));
		tmp = 0;
	}
	// HIDDEN -> OUTPUT
	for(int j=0;j<output_array_size;j++){
		for(int i=0;i<hidden_array_size;i++){
			tmp += (hidden[i] * weight_h_o[i][j]);
		}
		output[pattern][j] = (1.0 / (1.0 + exp(-1.0 * (tmp + bias[j+hidden_array_size]))));
	}
	return ;
}
void backward_pass(int pattern)
{
	double tmp=0;
	// COMPUTE ERRORSIGNAL FOR OUTPUT UNITS
	for(int i=0; i<output_array_size; i++) {
		errorsignal_output[i] = (target[pattern][i] - output[pattern][i]);
	}

	// COMPUTE ERRORSIGNAL FOR HIDDEN UNITS
	for(int i=0; i<hidden_array_size; i++) {
		for(int j=0; j<output_array_size; j++) { 
			tmp += (errorsignal_output[j] * weight_h_o[i][j]);
		}
		errorsignal_hidden[i] = hidden[i] * (1-hidden[i]) * tmp;
		tmp = 0.0;
	}
	// ADJUST WEIGHTS OF CONNECTIONS FROM HIDDEN TO OUTPUT UNITS
	double length = 0.0;
	for (int i=0; i<hidden_array_size; i++) {
		length += hidden[i]*hidden[i];
	}
	if (length<=0.1) length = 0.1;
	for(int i=0; i<hidden_array_size; i++) {
		for(int j=0; j<output_array_size; j++) {
			weight_h_o[i][j] += (learning_rate * errorsignal_output[j] * 
			hidden[i]/length);
		}
	}
	// ADJUST BIASES OF HIDDEN UNITS
	for(int i=hidden_array_size; i<bias_array_size; i++) {
		bias[i] += (learning_rate * errorsignal_output[i] / length);
	}
	// ADJUST WEIGHTS OF CONNECTIONS FROM INPUT TO HIDDEN UNITS
	length = 0.0;
	for (int i=0; i<input_array_size; i++) {
		length += input[pattern][i]*input[pattern][i];
	}
	if (length<=0.1) 
		length = 0.1;
	for(int i=0; i<input_array_size; i++) {
		for(int j=0; j<hidden_array_size; j++) {
			weight_i_h[i][j] += (learning_rate * errorsignal_hidden[j] * 
			input[pattern][i]/length);
		}
	}
	// ADJUST BIASES FOR OUTPUT UNITS
	for(int i=0; i<hidden_array_size; i++) {
		bias[i] += (learning_rate * errorsignal_hidden[i] / length);
	}
	return;
}
bool compare_to_target()
{
	double tmp = 0.0,error = 0.0;
	tmp = target[y_tmp][z_tmp] - output[y_tmp][z_tmp];
	if(tmp < 0)
		error -= tmp;
	else
		error += tmp;
	if(error > max_error_tollerance)
		return false;
	error = 0.0;
	for(int y=0;y<number_of_input_patterns;y++){
		for(int z=0;z<output_array_size;z++){
			tmp = target[y][z] - output[y][z];
			if (tmp < 0) 
				error -= tmp;
			else 
				error += tmp;
			if(error > max_error_tollerance) {
				y_tmp = y;
				z_tmp = z;
				return false;
			}
			error = 0.0;
		}
	}
	return true;
}

bool learn()
{
	for(int i=0;i<number_of_input_patterns;i++){
		forward_pass(i);
		backward_pass(i);
	}
	if(compare_to_target()){
		cout << endl << "learning successful" << endl;
		return 1;
	}
	cout << endl << "learning not successful yet" << endl;
	return 0;
}
void output_to_screen(int pattern)
{
	int x;
	cout << endl << "Output pattern:" << endl;
	for(x=0; x<output_array_size; x++) {
		cout << endl << (x+1) << ": " << output[pattern][x] << "    binary: ";
		if(output[pattern][x] >= ub) 
			cout << "1";
		else if(output[pattern][x]<=lb) 
			cout << "0";
		else 
			cout << "intermediate value";
	}
	cout << endl;
	return;
}
void test()
{
	for(int i=0;i<number_of_input_patterns;i++){
		forward_pass(i);
		output_to_screen(i);
	}
	return;
}
int main()
{
	freopen("in","r",stdin);
	init();
	learn();
	test();
	//學習次數
	for(int i=2;i<=10000;i++){
		cout << endl << "start learning round " << i << ":"<<endl;
		if(learn()){
			printf("\n\n FINISH LEARNING!! \n");
			break;
		}
		else
			test();
	}
	return 0;
}