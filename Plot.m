Serical = 2:0.1:7;
number = 10.^(-Serical);
Y = zeros(length(number),4);
for j = 1:4
    for k = 1:(length(number))
        Y(k,j) = Test(j,10^(-5.5),number(k));
    end
end
plot(Serical,Y(:,1),Serical,Y(:,2),Serical,Y(:,3),Serical,Y(:,4));