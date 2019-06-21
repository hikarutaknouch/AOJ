#include <bits/stdc++.h>
#define REP(i, n) for(int i = 0; i < n; i++)
#define REPP(i, n) for(int i = 1; i <= n; i++)
#define REPR(i, n) for(int i = n; i >= 0; i--)
#define FOR(i, m, n) for(int i = m; i < n; i++)
#define ALL(v) v.begin(), v.end()
#define UNIQUE(v) v.erase(unique(v.begin(), v.end()), v.end());
using namespace std;
typedef long long ll;
typedef pair<ll, ll> p;
const ll MOD = 1000000007;

int main() {
    stack<int> s;
    string str;
    int a,b;
    while(cin >> str) {
        if(str=="+") {
            a = s.top(); s.pop();
            b = s.top(); s.pop();
            s.push(b+a);
        }
        else if(str=="-") {
            a = s.top(); s.pop();
            b = s.top(); s.pop();
            s.push(b-a);
        }
        else if(str=="*") {
            a = s.top(); s.pop();
            b = s.top(); s.pop();
            s.push(b*a);
        }
        else s.push(stoi(str));
    }
    cout << s.top() << endl;
    return 0;
}