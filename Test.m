function [ s ] = Test( number,Q,R )

% getdate
date = xlsread('C:\Users\Administrator\Desktop\RailAccelerateTest.xlsx',number);
a_x = date(:,3);a_y = date(:,4);a_z = date(:,5);
%theta_x = date(:,6);theta_y = date(:,7);theta_z = date(:,8);

A0 = [a_x,a_y,a_z];
A1 = A0;A2 = A0.';

% remove G
%for j = 1:length(A0(1))
%    A1(j,:) = Transform(A0(j,:),[theta_x(j),theta_y(j),theta_z(j)]);
%end

% KalmanFilter
for j = 1:length(A0(1,:))
    A2(j,:) = KalmanFilter((A1(:,j).'),Q,R,0,1);
end
A2 = A2.';

% Integration
V = Integration(A2,0.01);
S = Integration(V,0.01);

s = S(length(S));
%plot
%x = 1:length(A0(:,1));
%plot(x,A0(:,1),x,(A2(:,1)),x,S(:,1));
%grid on;
%text(0,0,num2str(S(length(S))));
end