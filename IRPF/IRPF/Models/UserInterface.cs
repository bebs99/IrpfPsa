using System;
using System.Collections.Generic;

namespace IRPF.Models
{
    public interface UserInterface
    {
        void insert(User u);
        void modify(User u);
        User search(String cpf);
        List<User> getElderly();
        List<User> getAll();
    }
}
