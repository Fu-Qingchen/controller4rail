%function [ A1 ] = Test( number,Q,R )

number = 1;Q = 10^(-5.5);R = 10^(-2.5);

% getdate
date = xlsread('C:\Users\Administrator\Desktop\RailAccelerateTest.xlsx',number);
%datetime.Format = 'yyyy-MM-dd HH:mm:ss:SSSSSSS';
%datetime = date(:,2);
a_x = date(:,3);a_y = date(:,4);a_z = date(:,5);
theta_x = date(:,6);theta_y = date(:,7);theta_z = date(:,8);

A0 = [a_x,a_y,a_z];
A1 = A0;A12 = A0;A2 = A0.';

% remove G
for j = 1:length(A0(:,1))
    A1(j,:) = Transform(A0(j,:),[theta_x(j),theta_y(j),theta_z(j)]);
end

% remove initial
ax_initial = mean(A1(:,1).');ay_initial = mean(A1(:,2).');az_initial = mean(A1(:,3).');
for j = 1:length(A0(:,1))
T = [1 0 0 0;
    0 1 0 0;
    0 0 1 0;
    -ax_initial -ay_initial -az_initial 1];
Atemp = [A1(j,1) A1(j,2) A1(j,3) 1];
Atemp = Atemp*T;
A12(j,:) = Atemp(1:3);
end

% KalmanFilter
for j = 1:length(A0(1,:))
    A2(j,:) = KalmanFilter((A12(:,j).'),Q,R,0,1);
end
A2 = A2.';

% Integration
V = Integration(A12,0.020);
S = Integration(V,0.020);

s = S(length(S),:);
% plot
x = 1:length(A0(:,1));
plot(x,A2(:,2),x,V(:,2),x,S(:,2));
grid on;
%text(0,0,num2str(S(length(S))));
%end