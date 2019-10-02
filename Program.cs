using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        class custom_a {
            private custom_b atrib_b = null;
            private custom_c atrib_c = null;
            private custom_j atrib_j = null;
            public custom_a(custom_b atrib_b, custom_c atrib_c, custom_j atrib_j) {
                this.atrib_b = atrib_b;
                this.atrib_c = atrib_c;
                this.atrib_j = atrib_j;

                atrib_c.cq = 24;
            }
            ~custom_a() {}
            public void a_method() {
                Console.WriteLine("method of a");
            }
            public custom_b set_get_atrib_b {
                set {
                    Console.WriteLine("set b");
                    atrib_b = value;
                }
                get {
                    Console.WriteLine("get b: ");
                    return atrib_b;
                }
            }
            public custom_c set_get_atrib_c {
                set {
                    Console.WriteLine("set c");
                    atrib_c = value;
                }
                get {
                    Console.WriteLine("get c: ");
                    return atrib_c;
                }
            }
            public custom_j set_get_atrib_j {
                set {
                    Console.WriteLine("set j");
                    atrib_j = value;
                }
                get {
                    Console.WriteLine("get j: ");
                    return atrib_j;
                }
            }
        }
        class custom_b {
            private custom_d atrib_d = null;
            public custom_b(custom_d atrib_d) {
                this.atrib_d = atrib_d;
            }
            ~custom_b() {}
            public void b_method() {
                Console.WriteLine("method of b");
            }
            public custom_d set_get_atrib_d {
                set {
                    Console.WriteLine("set d");
                    atrib_d = value;
                }
                get {
                    Console.WriteLine("get d: ");
                    return atrib_d;
                }
            }
        }
        class custom_c {
            private custom_e atrib_e = null;
            private custom_f atrib_f = null;
            private custom_k atrib_k = null;
            public custom_c(custom_e atrib_e, custom_f atrib_f, custom_k atrib_k) {
                this.atrib_e = atrib_e;
                this.atrib_f = atrib_f;
                this.atrib_k = atrib_k;
            }
            ~custom_c() {}
            public void c_method() {
                Console.WriteLine("method of c");
            }
            public custom_e set_get_atrib_e {
                set {
                    Console.WriteLine("set e");
                    atrib_e = value;
                }
                get {
                    Console.WriteLine("get e: ");
                    return atrib_e;
                }
            }
            public custom_f set_get_atrib_f {
                set {
                    Console.WriteLine("set f");
                    atrib_f = value;
                }
                get {
                    Console.WriteLine("get f: ");
                    return atrib_f;
                }
            }
            public custom_k set_get_atrib_k {
                set {
                    Console.WriteLine("set k");
                    atrib_k = value;
                }
                get {
                    Console.WriteLine("get k: ");
                    return atrib_k;
                }
            }
            public int cq {get; set;}
        }
        class custom_d {
            public custom_d() {}
            ~custom_d() {}
            public void d_method() {
                Console.WriteLine("method of d");
            }
        }
        class custom_e {
            public custom_e() {}
            ~custom_e() {}
            public void e_method() {
                Console.WriteLine("method of e");
            }
        }
        class custom_f {
            public custom_f() {}
            ~custom_f() {}
            public void f_method() {
                Console.WriteLine("method of f");
            }
        }
        class custom_j {
            public custom_j() {}
            ~custom_j() {}
            public void j_method() {
                Console.WriteLine("method of j");
            }
        }
        class custom_k {
            public custom_k() {}
            ~custom_k() {}
            public void k_method() {
                Console.WriteLine("method of k");
            }
        }
        static void Main(string[] args)
        {
            custom_d c_d = new custom_d();
            custom_e c_e = new custom_e();
            custom_f c_f = new custom_f();
            custom_k c_k = new custom_k();
            custom_j c_j = new custom_j();
            custom_b c_b = new custom_b(c_d);
            custom_c c_c = new custom_c(c_e, c_f, c_k);
            custom_a c_a = new custom_a(c_b, c_c, c_j);
            Console.WriteLine("access atribute: {0}", c_c.cq);
            Console.WriteLine("link aggregation");
            c_a.set_get_atrib_b.b_method();
            c_a.set_get_atrib_c.c_method();
            c_a.set_get_atrib_j.j_method();
            c_a.set_get_atrib_b.set_get_atrib_d.d_method();
            c_a.set_get_atrib_c.set_get_atrib_e.e_method();
            c_a.set_get_atrib_c.set_get_atrib_f.f_method();
            c_a.set_get_atrib_c.set_get_atrib_k.k_method();
        }
    }
}
