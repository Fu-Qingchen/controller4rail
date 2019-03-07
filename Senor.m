number = 1;
date = xlsread('C:\Users\Administrator\Desktop\RailAccelerateTest.xlsx',number);
a_x = date(:,3);a_y = date(:,4);a_z = date(:,5);
theta_x = date(:,6);theta_y = date(:,7);theta_z = date(:,8);
a_x = theta_z.';
%temp = 1:length(a_x);
a_x_fft = fft(a_x);
f = (0:length(a_x_fft)-1)*50/length(a_x_fft);
plot(f,abs(a_x_fft));